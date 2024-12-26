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

        private void lbl_ısıtmaSuresi_ArrowLeftClicked_1(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lbl_ısıtmaSuresi.Value.ToString());

            lbl_ısıtmaSuresi.Value = (currentValue - 5).ToString();
        }

        private void lbl_ısıtmaSuresi_ArrowRightClicked_1(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lbl_ısıtmaSuresi.Value.ToString());

            lbl_ısıtmaSuresi.Value = (currentValue + 5).ToString();
        }

        private void lbl_ısıtmaSuresi_NumPadClicked_1(object sender, EventArgs e)
        {
            KeyPad keyPad = new KeyPad();

            if (keyPad.ShowDialog() == true)
            {
                string girilenDeger = keyPad.GirilenDeger;

                lbl_ısıtmaSuresi.Value = girilenDeger;
            }
        }
    }
}
