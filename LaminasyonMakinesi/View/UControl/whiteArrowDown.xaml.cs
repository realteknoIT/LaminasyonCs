﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace LaminasyonMakinesi.View.UControl
{
    /// <summary>
    /// arrow.xaml etkileşim mantığı
    /// </summary>
    public partial class whiteArrowDown : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public whiteArrowDown()
        {
            InitializeComponent();
        }
    }
}
