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
                    db.Database.Initialize(true);

                    if (db.User.Count() == 0 && db.Game.Count() == 0)
                    {
                        string imagePath = @"Images\Games\";
                        Game Astroneer = new Game(1, "Astroneer", 600, imagePath + "image1.jpg");
                        db.Game.Add(Astroneer);
                        Game RDR = new Game(2, "Red Dead Redemption", 1200, imagePath + "image2.jpg");
                        db.Game.Add(RDR);
                        Game StreetFighters = new Game(3, "Street Fighters", 500, imagePath + "image3.jpg");
                        db.Game.Add(StreetFighters);
                        Game Warcraft3 = new Game(4, "Warcraft", 1000, imagePath + "image4.jpg");
                        db.Game.Add(Warcraft3);
                        Game RoR2 = new Game(5, "Risk of Rain 2", 800, imagePath + "image5.jpg");
                        db.Game.Add(RoR2);
                        /*Game RoR2 = new Game(6, "Risk of Rain 2", 800, imagePath + "image5.jpg");
                        db.Game.Add(RoR2);
                        Game RoR2 = new Game(7, "Risk of Rain 2", 800, imagePath + "image5.jpg");
                        db.Game.Add(RoR2);
                        Game RoR2 = new Game(8, "Risk of Rain 2", 800, imagePath + "image5.jpg");
                        db.Game.Add(RoR2);*/

                        User qwerty123 = new User(1, "qwerty123", "qwerty123@mail.ru", "qwerty123");
                        db.User.Add(qwerty123);
                        User GL = new User(2, "GL", "Grenade@mail.ru", "BOOM");
                        db.User.Add(GL);
                        qwerty123.Games.Add(RDR);
                        qwerty123.Games.Add(Astroneer);
                        GL.Games.Add(StreetFighters);
                        db.SaveChanges();
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show($"Ошибка Инициализации БД: {e.Message}");
            }
        }
    }
}
