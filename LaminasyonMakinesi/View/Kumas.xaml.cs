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
        private void lbl_ısıtmaSuresi_NumPadClicked_1(object sender, EventArgs e)
        {
            KeyPad keyPad = new KeyPad();

            if (keyPad.ShowDialog() == true)
            {
                string girilenDeger = keyPad.GirilenDeger;

                lbl_ısıtmaSuresi.Value = girilenDeger;
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
        //soğutma
        private void lbl_sogutmaSuresi_ArrowLeftClicked(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lbl_sogutmaSuresi.Value.ToString());

            lbl_sogutmaSuresi.Value = (currentValue - 5).ToString();
        }

        private void lbl_sogutmaSuresi_ArrowRightClicked(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lbl_sogutmaSuresi.Value.ToString());

            lbl_sogutmaSuresi.Value = (currentValue + 5).ToString();
        }

        private void lbl_sogutmaSuresi_NumPadClicked(object sender, EventArgs e)
        {
            KeyPad keyPad = new KeyPad();

            if (keyPad.ShowDialog() == true)
            {
                string girilenDeger = keyPad.GirilenDeger;

                lbl_sogutmaSuresi.Value = girilenDeger;
            }
        }
        //kumaş-astar
        private void lbl_kumasAstarSilindirMesafe_ArrowLeftClicked_1(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lbl_kumasAstarSilindirMesafe.Value.ToString());

            lbl_kumasAstarSilindirMesafe.Value = (currentValue - 5).ToString();
        }

        private void lbl_kumasAstarSilindirMesafe_ArrowRightClicked_1(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lbl_kumasAstarSilindirMesafe.Value.ToString());

            lbl_kumasAstarSilindirMesafe.Value = (currentValue + 5).ToString();
        }

        private void lbl_kumasAstarSilindirMesafe_NumPadClicked(object sender, EventArgs e)
        {
            KeyPad keyPad = new KeyPad();

            if (keyPad.ShowDialog() == true)
            {
                string girilenDeger = keyPad.GirilenDeger;

                lbl_kumasAstarSilindirMesafe.Value = girilenDeger;
            }
        }
        //brülör mesafe
        private void lbl_sagBrulorMesafe_ArrowLeftClicked_1(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lbl_sagBrulorMesafe.Value.ToString());

            lbl_sagBrulorMesafe.Value = (currentValue - 5).ToString();
        }

        private void lbl_sagBrulorMesafe_ArrowRightClicked_1(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lbl_sagBrulorMesafe.Value.ToString());

            lbl_sagBrulorMesafe.Value = (currentValue + 5).ToString();
        }

        private void lbl_sagBrulorMesafe_NumPadClicked_1(object sender, EventArgs e)
        {
            KeyPad keyPad = new KeyPad();

            if (keyPad.ShowDialog() == true)
            {
                string girilenDeger = keyPad.GirilenDeger;

                lbl_sagBrulorMesafe.Value = girilenDeger;
            }
        }

        private void Lbl_kumasAstarSilindirMesafe_ArrowLeftClicked(object sender, EventArgs e)
        {
            Globals.UpdateStatus("kumas astar down");
        }

        private void Lbl_kumasAstarSilindirMesafe_ArrowRightClicked(object sender, EventArgs e)
        {
            Globals.UpdateStatus("kumas astar up");

        }

        private void Lbl_sagBrulorMesafe_ArrowLeftClicked(object sender, EventArgs e)
        {
            Globals.UpdateStatus("brulor astar down");

        }

        private void Lbl_sagBrulorMesafe_ArrowRightClicked(object sender, EventArgs e)
        {
            Globals.UpdateStatus("brulor astar up");

        }

        private void Lbl_ısıtmaSuresi_ArrowLeftClicked(object sender, EventArgs e)
        {
            Globals.UpdateStatus("isitma down");
        }

        private void Lbl_ısıtmaSuresi_ArrowRightClicked(object sender, EventArgs e)
        {
            Globals.UpdateStatus("isitma up");

        }

        private void Lbl_sogutmaSuresi_ArrowLeftClicked(object sender, EventArgs e)
        {
            Globals.UpdateStatus("sogutma down");

        }

        private void Lbl_sogutmaSuresi_ArrowRightClicked(object sender, EventArgs e)
        {
            Globals.UpdateStatus("sogutma astar up");

        }



    }
}
