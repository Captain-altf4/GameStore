using GameStore.Command;
using GameStore.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;

namespace GameStore.ViewModel
{
    class AuthWindowModel : INotifyPropertyChanged
    {
        public event EventHandler EventCloseWindow;

        string currentUserLogin;
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
