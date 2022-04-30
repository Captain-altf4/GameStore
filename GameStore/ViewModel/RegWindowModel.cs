using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using GameStore.Command;
using GameStore.Model;
using GameStore.ModelContext;
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
                    using (DBContext db = new DBContext())
                    {
                        PasswordBox pb = (PasswordBox)obj;
                        string? password = pb.Password;
                        User? user = db.User.Where(u => u.Login == currentUserLogin).FirstOrDefault();

                        if (user == null && 
                            LoginData.CheckLogin(currentUserLogin) &&
                            LoginData.CheckMail(currentUserMail) &&
                            LoginData.CheckPassword(pb.Password))
                        {
                            if (password != null)
                            {
                                int maxId = db.User.Max(u => u.Id);
                                User newUser = new User(maxId + 1, currentUserLogin, currentUserMail, password);
                                db.User.Add(newUser);
                                db.SaveChanges();
                                MessageBox.Show("Пользователь создан!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Такой пользователь уже существует или данные неверны!");
                        }
                    }
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
