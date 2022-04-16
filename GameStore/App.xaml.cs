using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using GameStore.Model;
using GameStore.ModelContext;

namespace GameStore
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            WindowsBuilder.ShowAuthWindow();
            InitDB();
            base.OnStartup(e);
        }

        void InitDB()
        {
            try
            {
                using (DBContext db = new DBContext())
                {
                    db.Database.Initialize(false);

                    if (db.User.Count() == 0 && db.Game.Count() == 0)
                    {
                        string imagePath = @"Images\Games\";
                        Game Astroneer = new Game(1, "Astroneer", 200, imagePath + "image1");
                        db.Game.Add(Astroneer);
                        Game RDR = new Game(1, "Red Dead Redemption", 200, imagePath + "image2");
                        db.Game.Add(RDR);
                        Game StreetFighters = new Game(1, "Street Fighters", 200, imagePath + "image1");
                        db.Game.Add(StreetFighters);

                        User qwerty123 = new User(0, "qwerty123", "qwerty123@mail.ru", "qwerty123");
                        db.User.Add(qwerty123);
                        User GL = new User(0, "GL", "Grenade@mail.ru", "!!BOOM!!");
                        db.User.Add(GL);
                        qwerty123.Games.Add(RDR);
                        qwerty123.Games.Add(Astroneer);
                        GL.Games.Add(StreetFighters);
                        db.SaveChanges();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка Инициализации БД!");
            }
        }
    }
}
