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
    /// Astar.xaml etkileşim mantığı
    /// </summary>
    public partial class Astar : Page
    {
        public Astar()
        {
            InitializeComponent();
        }

        private void sagBrulorMesafe_MouseDown(object sender, MouseButtonEventArgs e)
        {

            KeyPad keyPad= new KeyPad();

            if (keyPad.ShowDialog() == true)
            {
                string girilenDeger = keyPad.GirilenDeger;

                lbl_sagBrulorMesafe.Value = girilenDeger;
            }
        } 

        private void solBrulorMesafe_MouseDown(object sender, MouseButtonEventArgs e)
        {
            KeyPad keyPad = new KeyPad();

            if (keyPad.ShowDialog() == true)
            {
                string girilenDeger = keyPad.GirilenDeger;

                lbl_solBrulorMesafe.Value = girilenDeger;
            }
        }

        private void sungerKumasSilindirMesafe_MouseDown(Object sender, MouseButtonEventArgs e)
        {
           KeyPad keyPad = new KeyPad();

            if (keyPad.ShowDialog() == true)
            {
              string girilenDeger = keyPad.GirilenDeger;    

              lbl_sungerKumasSilindirMesafe.Value = girilenDeger;          
            }
        }
        //Bloğa tıklandığında numpad açılıyor girilen değeri valuenin mevcut değeri ile değiştiriyor
        private void kumasAstarSilindirMesafe_MouseDown(object sender, MouseButtonEventArgs e)
        {
            KeyPad keyPad = new KeyPad();

            if (keyPad.ShowDialog() == true)
            {
                string girilenDeger = keyPad.GirilenDeger;

                lbl_kumasAstarSilindirMesafe.Value = girilenDeger;
            }   
        }
        // Yukarı Tuşuna Tıklandığında Value'yi 5 arttırıyor
        private void sungerKumasSilindirMesafesiArrowUp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int currentValue = int.Parse(lbl_sungerKumasSilindirMesafe.Value.ToString());

            lbl_sungerKumasSilindirMesafe.Value = (currentValue + 5).ToString();
        }

        private void sungerKumasSilindirMesafesiArrowDown_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int currentValue = int.Parse(lbl_sungerKumasSilindirMesafe.Value.ToString());

            lbl_sungerKumasSilindirMesafe.Value = (currentValue - 5).ToString();
        }

        private void kumasAstarSilindirMesafeArrowUp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int currentValue = int.Parse(lbl_kumasAstarSilindirMesafe.Value.ToString());

            lbl_kumasAstarSilindirMesafe.Value = (currentValue + 5).ToString();
        }

        private void kumasAstarSilindirMesafeArrowDown_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int currentValue = int.Parse(lbl_kumasAstarSilindirMesafe.Value.ToString());

            lbl_kumasAstarSilindirMesafe.Value = (currentValue - 5).ToString();
        }

        private void sagbrulorMesafeArrowUp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int currentValue = int.Parse(lbl_sagBrulorMesafe.Value.ToString());

            lbl_sagBrulorMesafe.Value = (currentValue + 5).ToString();
        }

        private void sagbrulorMesafeArrowDown_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int currentValue = int.Parse(lbl_sagBrulorMesafe.Value.ToString());

            lbl_sagBrulorMesafe.Value = (currentValue - 5).ToString();
        }

        private void sagCekiciMotorKontrolArrowLeft_MouseDown(object sender, MouseButtonEventArgs e) //buraya tekrar bak
        {
            int currentValue = int.Parse(lbl_sungerKumasSilindirMesafe.Value.ToString());

            lbl_sungerKumasSilindirMesafe.Value = (currentValue + 5).ToString();
        }

        private void sagCekiciMotorKontrolArrowRight_MouseDown(object sender, MouseButtonEventArgs e) //buraya tekrar bak
        {
            int currentValue = int.Parse(lbl_sungerKumasSilindirMesafe.Value.ToString());

            lbl_sungerKumasSilindirMesafe.Value = (currentValue + 5).ToString();
        }

        private void solCekiciMotorKontrolArrowLeft_MouseDown(object sender, MouseButtonEventArgs e)  //buraya tekrar bak
        {
            int currentValue = int.Parse(lbl_sungerKumasSilindirMesafe.Value.ToString());

            lbl_sungerKumasSilindirMesafe.Value = (currentValue + 5).ToString();
        }

        private void solCekiciMotorKontrolArrowRight_MouseDown(object sender, MouseButtonEventArgs e) //buraya tekrar bak
        {
            int currentValue = int.Parse(lbl_sungerKumasSilindirMesafe.Value.ToString());

            lbl_sungerKumasSilindirMesafe.Value = (currentValue + 5).ToString();
        }

        private void solbrulorMesafeArrowUp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int currentValue = int.Parse(lbl_solBrulorMesafe.Value.ToString());

            lbl_solBrulorMesafe.Value = (currentValue + 5).ToString();
        }

        private void solbrulorMesafeArrowDown_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int currentValue = int.Parse(lbl_solBrulorMesafe.Value.ToString());

            lbl_solBrulorMesafe.Value = (currentValue - 5).ToString();
        }
































    }
}
