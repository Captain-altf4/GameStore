using GameStore.Custom_Controlls;
using GameStore.ViewModel;
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

namespace GameStore.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
            WindowBorder windowBorder = new WindowBorder(this);
            windowBorder.SetValue(Grid.RowProperty, 0);
            MainGrid.Children.Add(windowBorder);
            //DataContext = new AuthWindowModel(); //Связывает View со своей моделью
        }
    }
}
