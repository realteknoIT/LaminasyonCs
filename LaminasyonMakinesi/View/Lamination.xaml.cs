using LaminasyonMakinesi.View.UControl;
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
using LaminasyonMakinesi.View;
using System.Windows.Threading;
using LaminasyonMakinesi;

namespace LaminasyonMakinesi
{
    /// <summary>
    /// Lamination.xaml etkileşim mantığı
    /// </summary>
    public partial class Lamination : Page
    {
        string[] renk;
        public Lamination()
        {
            InitializeComponent();
            renk = new string[] {"Red","White","Orange","Yellow","Purple","Blue"};
        }

        private void sungerSol_MouseDown(object sender, MouseButtonEventArgs e)
        {
            LamineliKumas.Color = "Red;Red;White;Yellow;Orange";
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LamineliKumas.Color = "Red;Red;White;Yellow;Orange";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            LamineliKumas.Color = renk[rnd.Next(0, 6)] + ";" + renk[rnd.Next(0, 6)] + ";" + renk[rnd.Next(0, 6)] + ";" + renk[rnd.Next(0, 6)] + ";" + renk[rnd.Next(0, 6)] ;
        }
    }
}
