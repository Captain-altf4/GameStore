using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using GameStore.Command;
using GameStore.Views;

namespace GameStore.ViewModel
{
    class RegWindowModel
    {
        public event EventHandler EventCloseWindow;
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
        public void CloseWindow() => EventCloseWindow?.Invoke(this, EventArgs.Empty);
    }
}
