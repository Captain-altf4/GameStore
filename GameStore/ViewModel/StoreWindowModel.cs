using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.ViewModel
{
    internal class StoreWindowModel
    {
        public event EventHandler EventCloseWindow;
        public void CloseWindow() => EventCloseWindow?.Invoke(this, EventArgs.Empty);
    }
}
