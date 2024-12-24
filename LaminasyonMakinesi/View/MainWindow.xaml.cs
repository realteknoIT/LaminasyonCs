using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Threading;
using LaminasyonMakinesi.View;
using System.Windows.Controls;

namespace LaminasyonMakinesi
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private DispatcherTimer UItimer;
        private Timer ThreadTimer;
        private string _activePage;

        private Lamination laminasyon = new();
        private Sunger sünger = new();
        private Astar astar = new();
        private Kumas kumas = new();
        private DogSarma dogsarma = new();
        private Temizlik temizlik = new();
        private Recete recete = new();
        private Anasayfa anasayfa = new();

        public string ActivePage
        {
            get => _activePage;
            set
            {
                _activePage = value;
                OnPropertyChanged(nameof(ActivePage));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this; // Binding için
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            MaximizeToMouseMonitor();

            ThreadTimer = new Timer(ThreadTimerTick, null, 0, 300);

            UItimer = new DispatcherTimer();
            UItimer.Interval = TimeSpan.FromMilliseconds(500);
            UItimer.Tick += UItimerTick;
            UItimer.Start();
            ActivePage = "btnAnasayfa";
        }

        private void ThreadTimerTick(object? state)
        {
            Plc.ReadPlc();
        }

        private void UItimerTick(object? sender, EventArgs e)
        {
            ErrorControl();
            LoginControl();

            var currentPage = Pages.Content as dynamic;
            if (currentPage != null && currentPage.GetType().GetMethod("TimerAction") != null)
            {
                currentPage.TimerAction();
            }
        }

        private void ErrorControl()
        {
            if (Globals.HataIcerigi != "")
            {
                txbError.Title = Globals.HataBasligi;
                txbError.Visibility = Visibility.Visible;
            }
            else
            {
                txbError.Visibility = Visibility.Hidden;
            }
        }

        private void LoginControl()
        {
            if (Globals.LoggedInUser != null)
            {
                btnLogin.Text = "Kullanıcı : " + Globals.LoggedInUser.Username;
            }
            else
            {
                btnLogin.Text = "Giriş Yapınız!";
            }
        }

        private void txbError_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ErrorPage errorPage = new ErrorPage();
            errorPage.ShowDialog();
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void MaximizeToMouseMonitor()
        {
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
                var primaryScreen = Screen.AllScreens.FirstOrDefault(screen => screen.Primary);

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

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
                Application.Current.Shutdown();
        }

        private void btnNavbar_Click(object sender, RoutedEventArgs e)
        {
            // btnLaminasyon btnSunger btnAstar  btnKumas  btnDogSarma  btnTemizlik  btnRecete  btnKalibrasyon
            Button btn = (Button)sender;
            if (btn.Name == "btnLaminasyon")
            {
                Pages.Navigate(new Lamination());
                ActivePage = "btnLaminasyon";
            }
            else if (btn.Name == "btnSunger")
            {
                Pages.Navigate(new Sunger());
                ActivePage = "btnSunger";
            }
            else if (btn.Name == "btnAstar")
            {
                Pages.Navigate(new Astar());
                ActivePage = "btnAstar";
            }
            else if (btn.Name == "btnKumas")
            {
                Pages.Navigate(new Kumas());
                ActivePage = "btnKumas";
            }
            else if (btn.Name == "btnDogSarma")
            {
                Pages.Navigate(new DogSarma());
                ActivePage = "btnDogSarma";
            }
            else if (btn.Name == "btnBakim")
            {
                Pages.Navigate(new Temizlik());
                ActivePage = "btnBakim";
            }
            else if (btn.Name == "btnRecete")
            {
                Pages.Navigate(new Recete());
                ActivePage = "btnRecete";
            }
            else if (btn.Name == "btnAnasayfa")
            {
                Pages.Navigate(new Anasayfa());
                ActivePage = "btnAnasayfa";
            }
        }

        private void btnLogin_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (btnLogin.Text == "Giriş Yapınız!")
            {
                LoginPage Page = new LoginPage();
                Page.ShowDialog();
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    Globals.LoggedInUser = null;
                }
            }
        }
    }
}
