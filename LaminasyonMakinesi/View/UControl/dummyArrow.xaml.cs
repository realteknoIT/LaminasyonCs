using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace LaminasyonMakinesi.View.UControl
{
    /// <summary>
    /// dummyArrow.xaml etkileşim mantığı
    /// </summary>
    public partial class dummyArrow : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public dummyArrow()
        {
            InitializeComponent();
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool run;
        public bool Run
        {
            get { return run; }
            set
            {
                if (run != value)
                {
                    run = value;
                    OnPropertyChanged(nameof(Run));

                    if (run)
                        StartAnimation();
                    else
                        StopAnimation();
                }
            }
        }

        // Animasyonu Başlat
        private void StartAnimation()
        {
            var storyboard = (Storyboard)FindResource("MoveStoryboard");
            storyboard.Begin(this, true); // Tekrar başlatılabilir şekilde başlat
        }

        // Animasyonu Durdur
        private void StopAnimation()
        {
            var storyboard = (Storyboard)FindResource("MoveStoryboard");
            storyboard.Pause(this); // Duraklat
        }
    }
}
