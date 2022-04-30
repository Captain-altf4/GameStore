using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media.Imaging;
using GameStore.Command;
using GameStore.ModelContext;
using Microsoft.Win32;

namespace GameStore.ViewModel
{
    internal class StoreWindowModel
    {
        public event EventHandler EventCloseWindow;

        private BaseCommands loadAvatar;

        public BaseCommands LoadAvatar
        {
            get
            {
                //Если Null, тогда выполнится код ниже, если не Null, то возьмёт переменную как есть
                return loadAvatar ??
                (loadAvatar = new BaseCommands(obj =>
                {
                    OpenFileDialog opf = new OpenFileDialog();
                    opf.Filter = "Images (*.jpg)|*.jpg";
                    opf.ShowDialog();
                    if (opf.FileName != "")
                    {
                        BitmapImage image = new BitmapImage(new Uri(opf.FileName));
                        using (DBContext db = new DBContext())
                        {
                            byte[] avatar = new byte[0];
                            foreach (var u in db.User)
                            {
                                if (u.Id == LoginData.CurrentUser.Id)
                                {
                                    u.Avatar = DataTransform.JpgToByte(image);
                                    break;
                                }
                            }
                            db.SaveChanges();
                        }
                    }
                }));
            }
        }

        public void CloseWindow() => EventCloseWindow?.Invoke(this, EventArgs.Empty);
    }
}
