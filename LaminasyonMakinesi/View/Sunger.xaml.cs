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
        
        private void lbl_ısıtmaSuresi1_ArrowLeftClicked(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lbl_ısıtmaSuresi1.Value.ToString());

            lbl_ısıtmaSuresi1.Value = (currentValue - 5).ToString();
        }

        private void lbl_ısıtmaSuresi1_ArrowRightClicked(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lbl_ısıtmaSuresi1.Value.ToString());

            lbl_ısıtmaSuresi1.Value = (currentValue + 5).ToString();
        }

        private void lbl_ısıtmaSuresi1_NumPadClicked(object sender, EventArgs e)
        {
            KeyPad keyPad = new KeyPad();

            if (keyPad.ShowDialog() == true)
            {
                string girilenDeger = keyPad.GirilenDeger;

                lbl_ısıtmaSuresi1.Value = girilenDeger;
            }
        }

        private void lbl_sogutmaSuresi1_ArrowLeftClicked(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lbl_ısıtmaSuresi1.Value.ToString());

            lbl_sogutmaSuresi1.Value = (currentValue - 5).ToString();
        }

        private void lbl_sogutmaSuresi1_ArrowRightClicked(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lbl_ısıtmaSuresi1.Value.ToString());

            lbl_sogutmaSuresi1.Value = (currentValue + 5).ToString();
        }

        private void lbl_sogutmaSuresi1_NumPadClicked(object sender, EventArgs e)
        {
            KeyPad keyPad = new KeyPad();

            if (keyPad.ShowDialog() == true)
            {
                string girilenDeger = keyPad.GirilenDeger;

                lbl_sogutmaSuresi1.Value = girilenDeger;
            }
        }

        private void Lbl_ısıtmaSuresi1_ArrowLeftClicked(object sender, EventArgs e)
        {
            Globals.UpdateStatus("ısıtma suresi down");

        }

        private void Lbl_ısıtmaSuresi1_ArrowRightClicked(object sender, EventArgs e)
        {
            Globals.UpdateStatus("ısıtma suresi up");

        }

        private void Lbl_sogutmaSuresi1_ArrowLeftClicked(object sender, EventArgs e)
        {
            Globals.UpdateStatus("sogutma suresi down");
        }

        private void Lbl_sogutmaSuresi1_ArrowRightClicked(object sender, EventArgs e)
        {
            Globals.UpdateStatus("sogutma suresi up");

        }
    }
}
