using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using Sharp7;
using System.Data.SqlClient;
using System.IO;
using LaminasyonMakinesi;
using System.Windows.Media;

namespace LaminasyonMakinesi
{
    /// <summary>
    /// Loading.xaml etkileşim mantığı
    /// </summary>
    public partial class Loading : Window
    {
        int DelayCarpan = 1;
        public Loading()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            StartLoading();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void StartLoading()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.RunWorkerAsync();
        }

        private void Worker_DoWork(object? sender, DoWorkEventArgs e)
        {
            Config.LoadConfig();
            // PLC Bağlantısı
            UpdateStatus("PLC'lere Bağlanılıyor...");
            int tryConnect = 0;
            Config.PlcStatu = 1;
            while (Config.PlcStatu != 0 && tryConnect < Globals.ConnectTryCount)
            {
                Config.PlcStatu = Config.Plc.ConnectTo(Config.PlcIP, 0, 0);
                Task.Delay(500).Wait();
                tryConnect++;
            }
            if (Config.PlcStatu != 0) UpdateStatus($"Laminasyon PLC Bağlanamadı: {Globals.PlcError(Config.PlcStatu)}", true, "Program Açılırken Bazı Hatalar Oluştu!");
            tryConnect = 0;

            // Veritabanı Bağlantısı
            UpdateStatus("Veritabanına Bağlanılıyor...");
            Task.Delay(3 * DelayCarpan).Wait();
            CheckAndCreateDatabase();

            // Tablo Kontrolü ve Oluşturma
            UpdateStatus("Tablolar kontrol ediliyor...");
            Task.Delay(3 * DelayCarpan).Wait();
            CheckAndCreateTables();

            // Arayüz Yükleniyor
            UpdateStatus("Arayüz Yükleniyor...");
            Task.Delay(1 * DelayCarpan).Wait(); // Arayüz yükleme işlemi burada yapılır

        }
        private void Worker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            // Ana sayfaya geçiş
            Application.Current.Dispatcher.Invoke(() =>
            {
                MainWindow mainPage = new MainWindow();
                mainPage.Show();
                this.Close();
            });
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            MaximizeToMouseMonitor();
        }
        private void CheckAndCreateDatabase()
        {
            // Genel bağlantı dizesi (master veritabanına bağlanmak için)   Server=localhost;Database=master;User Id=sa;Password=YourStrongPassword;
            string masterConnectionString = "Server=" + Config.Server + ";Database=master;User Id=" + Config.User + ";Password=" + Config.Password + "; connection timeout=5;MultipleActiveResultSets=True;";
            using (SqlConnection masterConnection = new SqlConnection(masterConnectionString))
            {
                try
                {
                    masterConnection.Open();
                    // Veritabanı adını kontrol etme sorgusu
                    string checkDbQuery = "IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = '" + Config.Database + "') BEGIN CREATE DATABASE " + Config.Database + " END";
                    using (SqlCommand command = new SqlCommand(checkDbQuery, masterConnection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    UpdateStatus($"Veritabanı oluşturma sırasında bir hata oluştu: {ex.Message}", true, "Program Açılırken Bazı Hatalar Oluştu!");
                }
            }

            // Şimdi Lamination1 veritabanına bağlanıyoruz
            try
            {
                Config.SqlAdress = "Server=" + Config.Server + ";Database=" + Config.Database + ";User Id=" + Config.User + ";Password=" + Config.Password + "; connection timeout=5;MultipleActiveResultSets=True;";
                Config.SqlConnection = new SqlConnection(Config.SqlAdress);
                Config.SqlConnection.Open();
                UpdateStatus("Lamination veritabanına başarıyla bağlanıldı.");
            }
            catch (Exception ex)
            {
                UpdateStatus($"Veritabanına bağlanırken bir hata oluştu: {ex.Message}", true, "Program Açılırken Bazı Hatalar Oluştu!");
            }
        }
        private void CheckAndCreateTables()
        {
            Globals.Users.Add(new User
            {
                Username = Globals.defaultUser,
                Password = Globals.defaultPassword,
                Role = "1"
            });

            // Receteler Tablosu Kontrolü ---------------------------------------------------------------------------------------------------
            try
            {

                string checkTableQuery = @"
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Receteler')
BEGIN
    CREATE TABLE Receteler
    (
        id INT PRIMARY KEY IDENTITY(1,1),
        kodu NVARCHAR(50) NOT NULL,
        adi NVARCHAR(100) NOT NULL,
        kumas_id INT NULL,
        astar_id INT NULL,
        sunger_id INT NULL,
        astar_durumu NVARCHAR(50) NULL,
        aciklama NVARCHAR(200) NULL,
        olusturma_tarihi DATETIME NOT NULL DEFAULT GETDATE(),
        duzenleme_tarihi DATETIME NULL
    )
END
                                             ";

                using (SqlCommand command = new SqlCommand(checkTableQuery, Config.SqlConnection))
                {
                    command.ExecuteNonQuery();
                }

                UpdateStatus("Receteler tablosu kontrol edildi ve yoksa oluşturuldu.");
            }
            catch (Exception ex)
            {
                UpdateStatus($"Tablo oluşturma sırasında bir hata oluştu: {ex.Message}", true, "Program Açılırken Bazı Hatalar Oluştu!");
            }
            Task.Delay(300).Wait();

            // Astar Tablosu Kontrolü ---------------------------------------------------------------------------------------------------
            try
            {

                string checkTableQuery = @"
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Astar')
BEGIN
    CREATE TABLE Astar
    (
        id INT PRIMARY KEY IDENTITY(1,1),
        kodu NVARCHAR(50) NOT NULL,
        adi NVARCHAR(100) NOT NULL,
        en INT NULL,
        enTolerans INT NULL,
        kalinlik INT NULL,
        kalinlikTolerans INT NULL,
        cinsi NVARCHAR(200) NULL,
        renk NVARCHAR(100) NOT NULL
    )
END
                                             ";

                using (SqlCommand command = new SqlCommand(checkTableQuery, Config.SqlConnection))
                {
                    command.ExecuteNonQuery();
                }

                UpdateStatus("Astar tablosu kontrol edildi ve yoksa oluşturuldu.");
            }
            catch (Exception ex)
            {
                UpdateStatus($"Tablo oluşturma sırasında bir hata oluştu: {ex.Message}", true, "Program Açılırken Bazı Hatalar Oluştu!");
            }
            Task.Delay(3 * DelayCarpan).Wait();

            // Kumas Tablosu Kontrolü ---------------------------------------------------------------------------------------------------
            try
            {

                string checkTableQuery = @"
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Kumas')
BEGIN
    CREATE TABLE Kumas
    (
        id INT PRIMARY KEY IDENTITY(1,1),
        kodu NVARCHAR(50) NOT NULL,
        adi NVARCHAR(100) NOT NULL,
        en INT NULL,
        enTolerans INT NULL,
        kalinlik INT NULL,
        kalinlikTolerans INT NULL,
        cinsi NVARCHAR(200) NULL,
        renk NVARCHAR(100) NOT NULL
    )
END
                                             ";

                using (SqlCommand command = new SqlCommand(checkTableQuery, Config.SqlConnection))
                {
                    command.ExecuteNonQuery();
                }

                UpdateStatus("Kumaş tablosu kontrol edildi ve yoksa oluşturuldu.");
            }
            catch (Exception ex)
            {
                UpdateStatus($"Tablo oluşturma sırasında bir hata oluştu: {ex.Message}", true, "Program Açılırken Bazı Hatalar Oluştu!");
            }
            Task.Delay(3 * DelayCarpan).Wait();

            // Sunger Tablosu Kontrolü ---------------------------------------------------------------------------------------------------
            try
            {

                string checkTableQuery = @"
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Sunger')
BEGIN
    CREATE TABLE Sunger
    (
        id INT PRIMARY KEY IDENTITY(1,1),
        kodu NVARCHAR(50) NOT NULL,
        adi NVARCHAR(100) NOT NULL,
        dansite INT NULL,
        en INT NULL,
        enTolerans INT NULL,
        kalinlik INT NULL,
        kalinlikTolerans INT NULL,
        cinsi NVARCHAR(200) NULL,
        renk NVARCHAR(100) NOT NULL
    )
END
                                             ";

                using (SqlCommand command = new SqlCommand(checkTableQuery, Config.SqlConnection))
                {
                    command.ExecuteNonQuery();
                }

                UpdateStatus("Sünger tablosu kontrol edildi ve yoksa oluşturuldu.");

            }
            catch (Exception ex)
            {
                UpdateStatus($"Tablo oluşturma sırasında bir hata oluştu: {ex.Message}", true, "Program Açılırken Bazı Hatalar Oluştu!");
            }
            Task.Delay(3 * DelayCarpan).Wait();

            // Kullanicilar Tablosu Kontrolü ---------------------------------------------------------------------------------------------------
            try
            {

                string checkTableQuery = @"
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Kullanicilar')
BEGIN
    CREATE TABLE Kullanicilar
    (
        id INT PRIMARY KEY IDENTITY(1,1),
        Username NVARCHAR(200) NOT NULL,
        Password NVARCHAR(50) NOT NULL,
        Authority NVARCHAR(50) NOT NULL
    )
END
                                             ";

                using (SqlCommand command = new SqlCommand(checkTableQuery, Config.SqlConnection))
                {
                    command.ExecuteNonQuery();
                }

                UpdateStatus("Kullanıcı tablosu kontrol edildi ve yoksa oluşturuldu.");

                Config.LoadUsersFromDatabase();
            }
            catch (Exception ex)
            {
                UpdateStatus($"Kullanıcı tablosu  oluşturma sırasında bir hata oluştu: {ex.ToString()}", true, "Program Açılırken Bazı Hatalar Oluştu!");
            }
            Task.Delay(3 * DelayCarpan).Wait();
            InsertSampleData();
        }
        private void InsertSampleData()
        {
            try
            {
                // Receteler Tablosu İçin Örnek Veri
                string insertRecetelerQuery = @"
IF NOT EXISTS (SELECT * FROM Receteler)
BEGIN
    INSERT INTO Receteler (kodu, adi, kumas_id, astar_id, sunger_id, astar_durumu, aciklama)
    VALUES ('R001', 'Örnek Reçete', 1, 1, 1, 'Tamamlandı', 'Bu bir örnek reçetedir.')
END
        ";
                using (SqlCommand command = new SqlCommand(insertRecetelerQuery, Config.SqlConnection))
                {
                    command.ExecuteNonQuery();
                }

                UpdateStatus("Receteler tablosuna örnek veri eklendi.");
            }
            catch (Exception ex)
            {
                UpdateStatus($"Receteler tablosuna veri ekleme sırasında bir hata oluştu: {ex.Message}", true);
            }
            Task.Delay(3 * DelayCarpan).Wait();

            try
            {
                // Astar Tablosu İçin Örnek Veri
                string insertAstarQuery = @"
IF NOT EXISTS (SELECT * FROM Astar)
BEGIN
    INSERT INTO Astar (kodu, adi, en, enTolerans, kalinlik, kalinlikTolerans, cinsi, renk)
    VALUES ('A001', 'Örnek Astar', 150, 5, 10, 1, 'Pamuk', 'Beyaz')
END
        ";
                using (SqlCommand command = new SqlCommand(insertAstarQuery, Config.SqlConnection))
                {
                    command.ExecuteNonQuery();
                }

                UpdateStatus("Astar tablosuna örnek veri eklendi.");
            }
            catch (Exception ex)
            {
                UpdateStatus($"Astar tablosuna veri ekleme sırasında bir hata oluştu: {ex.Message}", true);
            }
            Task.Delay(3 * DelayCarpan).Wait();

            try
            {
                // Kumas Tablosu İçin Örnek Veri
                string insertKumasQuery = @"
IF NOT EXISTS (SELECT * FROM Kumas)
BEGIN
    INSERT INTO Kumas (kodu, adi, en, enTolerans, kalinlik, kalinlikTolerans, cinsi, renk)
    VALUES ('K001', 'Örnek Kumaş', 200, 10, 2, 0.5, 'Polyester', 'Mavi')
END
        ";
                using (SqlCommand command = new SqlCommand(insertKumasQuery, Config.SqlConnection))
                {
                    command.ExecuteNonQuery();
                }

                UpdateStatus("Kumaş tablosuna örnek veri eklendi.");
            }
            catch (Exception ex)
            {
                UpdateStatus($"Kumaş tablosuna veri ekleme sırasında bir hata oluştu: {ex.Message}", true);
            }
            Task.Delay(3 * DelayCarpan).Wait();

            try
            {
                // Sunger Tablosu İçin Örnek Veri
                string insertSungerQuery = @"
IF NOT EXISTS (SELECT * FROM Sunger)
BEGIN
    INSERT INTO Sunger (kodu, adi, dansite, en, enTolerans, kalinlik, kalinlikTolerans, cinsi, renk)
    VALUES ('S001', 'Örnek Sünger', 30, 100, 5, 10, 1, 'Yüksek Yoğunluk', 'Sarı')
END
        ";
                using (SqlCommand command = new SqlCommand(insertSungerQuery, Config.SqlConnection))
                {
                    command.ExecuteNonQuery();
                }

                UpdateStatus("Sünger tablosuna örnek veri eklendi.");
            }
            catch (Exception ex)
            {
                UpdateStatus($"Sünger tablosuna veri ekleme sırasında bir hata oluştu: {ex.Message}", true);
            }
            Task.Delay(3 * DelayCarpan).Wait();

            try
            {
                // Kullanicilar Tablosu İçin Örnek Veri
                string insertKullanicilarQuery = @"
IF NOT EXISTS (SELECT * FROM Kullanicilar)
BEGIN
    INSERT INTO Kullanicilar (Username, Password, Authority)
    VALUES ('MyusufGültekin', '68426633', '1')
END
        ";
                using (SqlCommand command = new SqlCommand(insertKullanicilarQuery, Config.SqlConnection))
                {
                    command.ExecuteNonQuery();
                }

                UpdateStatus("Kullanıcılar tablosuna örnek veri eklendi.");
            }
            catch (Exception ex)
            {
                UpdateStatus($"Kullanıcılar tablosuna veri ekleme sırasında bir hata oluştu: {ex.Message}", true);
            }
            Task.Delay(3 * DelayCarpan).Wait();
        }
        private void MaximizeToMouseMonitor()
        {
            var allScreens = Screen.AllScreens;
            var mousePosition = System.Windows.Forms.Cursor.Position;

            App.targetScreen = allScreens.FirstOrDefault(screen => screen.Bounds.Contains(mousePosition));

            if (App.targetScreen != null)
            {
                var workingArea = App.targetScreen.WorkingArea;

                // Pencere boyutlarını ayarla
                this.Left = workingArea.Left;
                this.Top = workingArea.Top;
                this.Width = workingArea.Width;
                this.Height = workingArea.Height;

                // Pencereyi maksimum yap
                this.WindowState = WindowState.Maximized;
                this.WindowStyle = WindowStyle.None; // İsteğe bağlı: Başlık çubuğunu kaldır
                this.ResizeMode = ResizeMode.NoResize; // İsteğe bağlı: Pencereyi yeniden boyutlandırmayı engelle
            }
            else
            {
                // Eğer mouse pozisyonu monitörlerden hiç birine denk gelmiyorsa, ana ekranda aç
                var primaryScreen = allScreens.FirstOrDefault(screen => screen.Primary);

                if (primaryScreen != null)
                {
                    var workingArea = primaryScreen.WorkingArea;

                    this.Left = workingArea.Left;
                    this.Top = workingArea.Top;
                    this.Width = workingArea.Width;
                    this.Height = workingArea.Height;

                    this.WindowState = WindowState.Maximized;
                    this.WindowStyle = WindowStyle.None; // İsteğe bağlı: Başlık çubuğunu kaldır
                    this.ResizeMode = ResizeMode.NoResize; // İsteğe bağlı: Pencereyi yeniden boyutlandırmayı engelle
                }
                else
                {
                    // Eğer ana ekran tespit edilemediyse (başka bir şey yapabilirsiniz)
                    MessageBox.Show("Ana ekran tespit edilemedi.");
                }
            }
        }
        private void UpdateStatus(string message, bool error = false, string title = "Bir Hatayla Karşılaşıldı!")
        {
            // Uygulama içindeki TextBlock'a mesajı yaz
            Application.Current.Dispatcher.Invoke(() =>
            {
                txtLoaded.Text = message;

                if (error)
                {
                    txtLoaded.Foreground = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    txtLoaded.Foreground = new SolidColorBrush(Colors.White);
                }
            });
            if (error)
            {
                Globals.UpdateStatus(message, error, title);
            }
        }
    }
}
