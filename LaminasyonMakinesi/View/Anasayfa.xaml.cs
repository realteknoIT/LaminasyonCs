using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LaminasyonMakinesi.View
{
    /// <summary>
    /// Anasayfa.xaml etkileşim mantığı
    /// </summary>
    public partial class Anasayfa : Page
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        public void Animation()
        {
                laminasyonSungerGirisSag.Run = Globals.SungerGirisIleri;
                laminasyonSungerGirisSol.Run = Globals.SungerGirisGeri;
                laminasyonKumasGirisSag.Run = Globals.KumasGirisIleri;
                laminasyonKumasGirisSol.Run = Globals.KumasGirisGeri;
                laminasyonAstarGirisSag.Run = Globals.AstarGirisIleri;
                laminasyonAstarGirisSol.Run = Globals.AstarGirisGeri;
                sungerDog.Run = Globals.SungerDogIleri;
                kumasDog.Run = Globals.KumasDogIleri;
                astarDog.Run = Globals.AstarDogIleri;
                lamineliDog.Run = Globals.LamineliIleri;

                dummyarrow1.Run = Globals.OrtalayiciAktif;
                dummyarrow2.Run = Globals.OrtalayiciAktif;
                dummyarrow3.Run = Globals.OrtalayiciAktif;
                dummyarrow4.Run = Globals.OrtalayiciAktif;
                dummyarrow5.Run = Globals.OrtalayiciAktif;
                dummyarrow6.Run = Globals.OrtalayiciAktif;
                laminasyonAstarAkis.Run = Globals.SuAkisAktif;
                laminasyonKumasAkis.Run = Globals.SuAkisAktif;
                laminasyonSungerAkis.Run = Globals.SuAkisAktif;
                kumasFlame.Visibility = Globals.KumasAlev ? Visibility.Visible : Visibility.Hidden;
                astarFlame.Visibility = Globals.AstarAlev ? Visibility.Visible : Visibility.Hidden;
        }
        public void TimerAction()
        {
            Animation();
        }
    }
}
