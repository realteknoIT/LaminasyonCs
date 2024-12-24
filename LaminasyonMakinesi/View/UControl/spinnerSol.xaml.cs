using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace LaminasyonMakinesi.View.UControl
{
    /// <summary>
    /// spinnerSol.xaml etkileşim mantığı
    /// </summary>
    public partial class spinnerSol : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double scales = 1;
        public spinnerSol()
        {
            InitializeComponent();
            StartAnimation();
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int targetWidth;
        public int TargetWidth
        {
            get { return targetWidth; }
            set
            {
                if (targetWidth != value)
                {
                    targetWidth = value;
                    OnPropertyChanged(nameof(TargetWidth));

                    double targetScale = (double)targetWidth / 23;
                    Scales = targetScale;
                }
            }
        }

        private double scalesProperty;
        public double Scales
        {
            get { return scalesProperty; }
            set
            {
                if (Math.Abs(scalesProperty - value) > 0.001)
                {
                    scalesProperty = value;
                    OnPropertyChanged(nameof(Scales));

                    scaleTransform.ScaleX = scalesProperty * -1; // Negative X scale for mirrored effect
                    scaleTransform.ScaleY = scalesProperty;
                }
            }
        }

        // Run Dependency Property
        public static readonly DependencyProperty RunProperty =
            DependencyProperty.Register(
                nameof(Run),
                typeof(bool),
                typeof(spinnerSol),
                new PropertyMetadata(true, OnRunChanged)); // Değişiklik algılayıcısı

        public bool Run
        {
            get { return (bool)GetValue(RunProperty); }
            set { SetValue(RunProperty, value); }
        }

        // Run Durumu Değiştiğinde Çalışacak Metod
        private static void OnRunChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (spinnerSol)d;
            if ((bool)e.NewValue) // Run true ise
            {
                control.StartAnimation();
            }
            else // Run false ise
            {
                control.StopAnimation();
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
