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
    /// LoginPage.xaml etkileşim mantığı
    /// </summary>
    public partial class LoginPage : Window
    {
        public LoginPage()
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
            if (PasswordBox.Text.Length < 8) // Maksimum 6 karakter kontrolü
            {
                Button button = sender as Button;
                PasswordBox.Text += button.Content.ToString();
            }
            else
            {
                var msg = new Message("Girilen Şifre Maksimum 8 Karakter Olmalı!");
                await msg.ShowWithTimeout(2000);
            }
        }

        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            PasswordBox.Text = string.Empty; // Şifreyi temizle
        }
        private async void Enter_Button_Click(object sender, RoutedEventArgs e)
        {
            string enteredPassword = PasswordBox.Text; // Şifre giriş alanı

            // Kullanıcıyı liste üzerinden bul
            var matchedUser = Globals.Users
                .FirstOrDefault(user => user.Password == enteredPassword);

            if (matchedUser != null)
            {
                // Başarılı giriş
                Globals.LoggedInUser = matchedUser;
                var msg = new Message($"Hoşgeldiniz {matchedUser.Username}, Yetki: {((matchedUser.Role=="1")?"Yönetici":"Kullanıcı")}");
                await msg.ShowWithTimeout(1000);
                // Ana ekrana geçiş
                this.Close();
            }
            else
            {
                // Hatalı giriş
                var msg = new Message("Kullanıcı adı veya şifre hatalı!");
                await msg.ShowWithTimeout(2000);
                PasswordBox.Text = string.Empty;
            }
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
                Enter_Button_Click(sender,e);
        }
    }
}
