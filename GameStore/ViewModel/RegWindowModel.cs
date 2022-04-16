using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using GameStore.Command;
using GameStore.Views;

namespace GameStore.ViewModel
{
    class RegWindowModel : INotifyPropertyChanged
    {
        public event EventHandler EventCloseWindow;
        string currentUserMail;

        public string CurrentUserMail
        {
            get { return currentUserMail; }
            set
            {
                currentUserMail = value;
                OnPropertyChanged("CurrentUserLogin");
            }
        }

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

        private BaseCommands changeToAuthWindow;

        public BaseCommands ChangeToAuthWindow
        {
            get
            {
                //Если Null, тогда выполнится код ниже, если не Null, то возьмёт переменную как есть
                return changeToAuthWindow ??
                    (changeToAuthWindow = new BaseCommands(obj =>
                    {
                        WindowsBuilder.ShowAuthWindow();
                        CloseWindow();
                    }));
            }
        }


        private BaseCommands regUser;

        public BaseCommands RegUser
        {
            get
            {
                return regUser ??
                    (regUser = new BaseCommands(obj =>
                    {
                        PasswordBox pb = (PasswordBox)obj;
                        MessageBox.Show($"Текущий пользователь: {currentUserLogin} {currentUserMail} {pb.Password}");
                    }));
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        public void CloseWindow() => EventCloseWindow?.Invoke(this, EventArgs.Empty);
    }
}
