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
    /// Sunger.xaml etkileşim mantığı
    /// </summary>
    public partial class Sunger : Page
    {
        public Sunger()
        {
            InitializeComponent();
        }

        private void ısıtmaSuresi1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            KeyPad keyPad = new KeyPad();

            if (keyPad.ShowDialog() == true)
            {
                string girilenDeger = keyPad.GirilenDeger;

                lbl_ısıtmaSuresi1.Value = girilenDeger;
            }
        }

        private void ısıtmaSuresiKontrolArrowUp1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int currentValue = int.Parse(lbl_ısıtmaSuresi1.Value.ToString());

            lbl_ısıtmaSuresi1.Value = (currentValue + 5).ToString();
        }

        private void ısıtmaSuresiKontrolArrowDown1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int currentValue = int.Parse(lbl_ısıtmaSuresi1.Value.ToString());

            lbl_ısıtmaSuresi1.Value = (currentValue - 5).ToString();
        }
        
        private void sogutmaSuresi1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            KeyPad keyPad = new KeyPad();

            if (keyPad.ShowDialog() == true)
            {
                string girilenDeger = keyPad.GirilenDeger;

                lbl_sogutmaSuresi1.Value = girilenDeger;
            }
        }

        private void sogutmaSuresiKontrolArrowUp1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int currentValue = int.Parse(lbl_ısıtmaSuresi1.Value.ToString());

            lbl_sogutmaSuresi1.Value = (currentValue + 5).ToString();
        }

        private void sogutmaSuresiKontrolArrowDown1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int currentValue = int.Parse(lbl_ısıtmaSuresi1.Value.ToString());

            lbl_sogutmaSuresi1.Value = (currentValue - 5).ToString();
        }

        private void cekiciMotorKontrolArrowLeft1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int currentValue = int.Parse(cekiciMotorKontrol1.Value.ToString());

            cekiciMotorKontrol1.Value = (currentValue + 5).ToString();
        }

        private void cekiciMotorKontrolArrowRight1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int currentValue = int.Parse(cekiciMotorKontrol1.Value.ToString());

            cekiciMotorKontrol1.Value = (currentValue - 5).ToString();
        }
    }
}
