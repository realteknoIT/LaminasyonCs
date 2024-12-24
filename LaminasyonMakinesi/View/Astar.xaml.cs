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
            KeyPad keypad = new KeyPad();

            if(keypad.ShowDialog() == true)
            {
                string girilenDeger = keypad.GirilenDeger;

                lbl_solBrulorMesafe.Value = girilenDeger;
            }
        }
    }
}
