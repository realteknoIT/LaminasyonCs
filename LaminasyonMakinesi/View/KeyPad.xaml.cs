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
using System.Windows.Shapes;

namespace LaminasyonMakinesi.View
{
    /// <summary>
    /// KeyPad.xaml etkileşim mantığı
    /// </summary>
    public partial class KeyPad : Window
    {
        public string GirilenDeger { get; private set; }

        public KeyPad()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PasswordBox.Text = string.Empty; // Şifreyi temizle
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            PasswordBox.Text += button.Content.ToString();
        }

        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            PasswordBox.Text = string.Empty; // Şifreyi temizle
        }
        private void Enter_Button_Click(object sender, RoutedEventArgs e)
        {
            // TextBox'tan değeri al
            GirilenDeger = PasswordBox.Text;

            // Dialog'u kapat
            DialogResult = true;
        }


        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            Key key = e.Key;
            // Eğer basılan tuş rakamsa (NumPad veya ana klavye)
            if (key >= Key.D0 && key <= Key.D9)
            {
                // Ana klavyeden girilen rakamlar (Key.D0 - Key.D9)
                PasswordBox.Text += (key - Key.D0).ToString();
            }
            else if (key >= Key.NumPad0 && key <= Key.NumPad9)
            {
                // Numpad'den girilen rakamlar (Key.NumPad0 - Key.NumPad9)
                PasswordBox.Text += (key - Key.NumPad0).ToString();
            }
            if (PasswordBox.Text.Length == 8)
                Enter_Button_Click(sender, e);
        }
    }
}
