using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Forms;
using Sharp7;
using System.Data.SqlClient;

namespace LaminasyonMakinesi
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static Mutex? 
            mutex = null;
        public static Screen? 
            targetScreen = Screen.AllScreens.FirstOrDefault(screen => screen.Primary);
 

        protected override void OnStartup(StartupEventArgs e)
        {
            const string appName = "LaminasyonMakinesi";
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                // Eğer bir kopya zaten çalışıyorsa yeni kopyayı kapat
                MessageBox.Show("Bu uygulamanın başka bir örneği zaten çalışıyor.");
                Application.Current.Shutdown();
            }
            else
            {
                base.OnStartup(e);
            }
        }
    }

}
