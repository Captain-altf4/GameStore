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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameStore.Custom_Controlls
{
    public partial class WindowBorder : UserControl
    {
        Window parent;
        public WindowBorder(Window parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        public WindowBorder()
        {
            InitializeComponent();
        }

        private void b_Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.parent.WindowState = WindowState.Minimized;
        }

        private void b_Close_Click(object sender, RoutedEventArgs e)
        {
            this.parent.Close();
        }

        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                parent.DragMove();
        }
    }
}
