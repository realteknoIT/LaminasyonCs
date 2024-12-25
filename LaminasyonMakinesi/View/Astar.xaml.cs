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
    }
}
