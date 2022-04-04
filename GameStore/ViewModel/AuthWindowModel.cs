using GameStore.Command;
using GameStore.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.ViewModel
{
    class AuthWindowModel
    {
        private BaseCommands changeToRegWindow;

        public BaseCommands ChangeToRegWindow
        {
            get
            {
                return changeToRegWindow ??
                    (changeToRegWindow = new BaseCommands(obj =>
                    {
                        RegWindow regWindow = new RegWindow();
                        regWindow.Show();
                    }));
            }
        }
    }
}
