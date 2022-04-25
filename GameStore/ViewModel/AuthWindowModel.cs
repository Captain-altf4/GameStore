using GameStore.Command;
using GameStore.ModelContext;
using GameStore.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace GameStore.ViewModel
{
    class AuthWindowModel : INotifyPropertyChanged
    {
        public event EventHandler EventCloseWindow;
        string currentUserLogin;

        public string CurrentUserLogin
        {
            get { return currentUserLogin; }
            set
            {
                currentUserLogin = value;
                OnPropertyChanged("CurrentUserLogin");
            }
        }

        private BaseCommands changeToRegWindow;

        public BaseCommands ChangeToRegWindow
        {
            get
            {
                //Если Null, тогда выполнится код ниже, если не Null, то возьмёт переменную как есть
                return changeToRegWindow ??
                    (changeToRegWindow = new BaseCommands(obj =>
                    {
                        WindowsBuilder.ShowRegWindow();
                        CloseWindow();
                    }));
            }
        }

        private BaseCommands loginUser;
        
        public BaseCommands LoginUser
        {
            get
            {
                return loginUser ??
                    (loginUser = new BaseCommands(obj =>
                    {
                        PasswordBox pb = (PasswordBox)obj;
                        using(DBContext db = new DBContext())
                        {
                            var user = db.User.Where(u => u.Login == currentUserLogin &&
                                                     u.Password == pb.Password).FirstOrDefault();

                            if(user != null)
                            {
                                LoginData.CurrentUser.Id = user.Id;
                                LoginData.CurrentUser.Login = user.Login;
                                LoginData.CurrentUser.UserMail = user.Mail;
                                WindowsBuilder.ShowStoreWindow();
                                CloseWindow();
                            }
                            else
                            {
                                MessageBox.Show("Пользователь не найден!");
                            }
                        }
                    }));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null){
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        public void CloseWindow() => EventCloseWindow?.Invoke(this, EventArgs.Empty);
    }
}
