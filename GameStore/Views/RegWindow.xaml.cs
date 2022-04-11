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
using GameStore.ViewModel;

namespace GameStore.Views
{
    /// <summary>
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
            WindowBorder windowBorder = new WindowBorder(this);
            windowBorder.SetValue(Grid.RowProperty, 0);
            MainGrid.Children.Add(windowBorder);
            //DataContext = new RegWindowModel();
        }

        private void tb_Login_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (LoginData.CheckLogin(tb_Login.Text))
                tb_Login.Foreground = new SolidColorBrush(Colors.Green);
            else
                tb_Login.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void tb_Mail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (LoginData.CheckMail(tb_Mail.Text))
                tb_Mail.Foreground = new SolidColorBrush(Colors.Green);
            else
                tb_Mail.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void pb_Password1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (LoginData.CheckPassword(pb_Password1.Password))
                pb_Password1.Foreground = new SolidColorBrush(Colors.Green);
            else
                pb_Password1.Foreground = new SolidColorBrush(Colors.Red);
            pb_Password2.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void pb_Password2_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pb_Password2.Password == pb_Password1.Password)
                pb_Password2.Foreground = new SolidColorBrush(Colors.Green);
            else
                pb_Password2.Foreground = new SolidColorBrush(Colors.Red);
        }
    }
}
