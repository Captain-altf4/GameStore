using System;
using System.Collections.Generic;
using System.Text;
using GameStore.ViewModel;
using GameStore.Views;

namespace GameStore
{
    public static class WindowsBuilder
    {
        public static void ShowAuthWindow()
        {
            var window = new AuthWindow();
            var viewModel = new AuthWindowModel();
            window.DataContext = viewModel;
            viewModel.EventCloseWindow += (sender, args) => { window.Close(); };
            window.Show();
        }

        public static void ShowRegWindow()
        {
            var window = new RegWindow();
            var viewModel = new RegWindowModel();
            window.DataContext = viewModel;
            viewModel.EventCloseWindow += (sender, args) => { window.Close(); };
            window.Show();
        }
    }
}
