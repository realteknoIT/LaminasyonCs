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
    /// Kumas.xaml etkileşim mantığı
    /// </summary>
    public partial class Kumas : Page
    {
        public Kumas()
        {
            InitializeComponent();
        }
            //ısıtma
       private void ısıtmaSuresi_MouseDown(object sender, MouseButtonEventArgs e)
       {
            KeyPad keyPad = new KeyPad();

            if (keyPad.ShowDialog() == true)
            {
                string girilenDeger = keyPad.GirilenDeger;

                lbl_ısıtmaSuresi.Value = girilenDeger;
            }
       }

        private void ısıtmaSuresiKontrolArrowUp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int currentValue = int.Parse(lbl_ısıtmaSuresi.Value.ToString());

            lbl_ısıtmaSuresi.Value = (currentValue + 5).ToString();
        }

        private void ısıtmaSuresiKontrolArrowDown_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int currentValue = int.Parse(lbl_ısıtmaSuresi.Value.ToString());

            lbl_ısıtmaSuresi.Value = (currentValue - 5).ToString();
        }
            //sogutma
        private void sogutmaSuresi_MouseDown(object sender, MouseButtonEventArgs e)
        {
            KeyPad keyPad = new KeyPad();

            if (keyPad.ShowDialog() == true)
            {
                string girilenDeger = keyPad.GirilenDeger;

                lbl_sogutmaSuresi.Value = girilenDeger;
            }
        }

        private void sogutmaSuresiKontrolArrowUp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int currentValue = int.Parse(lbl_ısıtmaSuresi.Value.ToString());

            lbl_sogutmaSuresi.Value = (currentValue + 5).ToString();
        }

        private void sogutmaSuresiKontrolArrowDown_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int currentValue = int.Parse(lbl_ısıtmaSuresi.Value.ToString());

            lbl_sogutmaSuresi.Value = (currentValue - 5).ToString();
        }
           // çekici motorun kontrolü
        private void cekiciMotorKontrolArrowLeft_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int currentValue = int.Parse(cekiciMotorKontrol.Value.ToString());

            cekiciMotorKontrol.Value = (currentValue + 5).ToString();
        }

        private void cekiciMotorKontrolArrowRight_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int currentValue = int.Parse(cekiciMotorKontrol.Value.ToString());

            cekiciMotorKontrol.Value = (currentValue - 5).ToString();
        }



    }
}
