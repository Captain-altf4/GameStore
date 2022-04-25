using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using GameStore.Custom_Controlls;
using GameStore.Model;
using GameStore.ModelContext;

namespace GameStore.Views
{
    public partial class StoreWindow : Window
    {
        public StoreWindow()
        {
            InitializeComponent();
            WindowBorderMaxBox windowBorder = new WindowBorderMaxBox(this);
            windowBorder.SetValue(Grid.RowProperty, 0);
            MainGrid.Children.Add(windowBorder);
            FillGrid();
        }

        void FillGrid()
        {
            using(DBContext db = new DBContext())
            {
                List<RowDefinition> rows = new List<RowDefinition>();
                int gamesCount = db.Game.Count();
                int rowsCount = (gamesCount + 1) / 2; 
                for (int i = 0; i < rowsCount; i++)
                {
                    rows.Add(new RowDefinition());
                    rows[i * 2].Height = new GridLength(30); //Берётся каждая чётная строка (0*2 1*2 2*2)
                    rows.Add(new RowDefinition());
                    rows[i * 2 + 1].Height = new GridLength(130, GridUnitType.Star); //130*
                }
                rows.Add(new RowDefinition());
                rows[rows.Count - 1].Height = new GridLength(30);

                for (int i = 0; i < rows.Count; i++)
                {
                    GameGrid.RowDefinitions.Add(rows[i]);
                }

                int columnNum = 1;
                int rowNum = 1;
                int index = 0;
                foreach (Game game in db.Game)
                {
                    Image currentImage = new Image();
                    BitmapImage logo = DataTransform.ByteToJpg(game.Image);
                    currentImage.Source = logo;
                    currentImage.SetValue(Grid.RowProperty, rowNum);
                    currentImage.SetValue(Grid.ColumnProperty, columnNum);
                    columnNum = (columnNum == 1) ? 3 : 1;
                    GameGrid.Children.Add(currentImage);
                    if ((index + 1) % 2 == 0)
                        rowNum += 2;
                    index++;
                }
            }
        }
    }
}
