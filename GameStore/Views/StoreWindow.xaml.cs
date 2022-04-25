using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using GameStore.Custom_Controlls;

namespace GameStore.Views
{
    public partial class StoreWindow : Window
    {
        public StoreWindow()
        {
            InitializeComponent();
            WindowBorderMaxBox windowBorder = new WindowBorderMaxBox(this);
            windowBorder.SetValue(Grid.RowProperty, 0);
            MainGrid.Children.Add(windowBorder);
        }
    }
}
