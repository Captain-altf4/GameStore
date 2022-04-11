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
            //DataContext = new AuthWindowModel(); //Связывает View со своей моделью
        }

        private void tb_Login_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (LoginData.CheckLogin(tb_Login.Text))
                tb_Login.Foreground = new SolidColorBrush(Colors.Green);
            else
                tb_Login.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void pb_Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (LoginData.CheckPassword(pb_Password.Password))
                pb_Password.Foreground = new SolidColorBrush(Colors.Green);
            else
                pb_Password.Foreground = new SolidColorBrush(Colors.Red);
        }
    }
}
