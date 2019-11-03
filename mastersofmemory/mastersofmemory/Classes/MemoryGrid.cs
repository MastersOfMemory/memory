using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace mastersofmemory.Classes
{
    class MemoryGrid
    {
        private Grid grid;
        const int rows = 4;
        const int cols = 4;

        private List<Tiles> tiles = new List<Tiles>();
        private int NumberOfClickedTiles = 0;
        private int previousTile;

        public MemoryGrid(Grid g)
        {
            grid = g;
            Initialize();
            AddImages();
            ShowTiles();
        }

        private void TileClick(Object sender, MouseButtonEventArgs e)
        {
            if (NumberOfClickedTiles < 2)
            {
                NumberOfClickedTiles++; //Als 1x geclickt is dan increment hij met 1 click
                Image image = (Image)sender; //Stuurt de event aan voor TileClick op een image
                int index = (int)image.Tag; //Variabele voor 
                image.Source = null; //
                tiles[index].Clicked();

                if (NumberOfClickedTiles == 2) //
                {
                    if (tiles[previousTile].Show() == tiles[index].Show()) //Check If Matched 
                    {
                        tiles[index].MakeInvisible(); //Tweede front-tile verdwijnt (visible = false)
                        tiles[previousTile].MakeInvisible(); //Eerste front-tile verdwijnt (visible = false)

                        MessageBox.Show("Goed!");

                    }
                    else
                    {
                        tiles[index].FlipToBack(); 
                        tiles[previousTile].FlipToBack();

                        MessageBox.Show("Fout!");
                    }

                    NumberOfClickedTiles = 0; //Het aantal geselecteerde tiles wordt weer gereset naar 0
                }
                else
                    previousTile = index;

                ShowTiles();
            }
        }

        private void AddImages()
        {
            List<ImageSource> images = GetImageList();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    tiles.Add(new Tiles(images.First()));
                    images.RemoveAt(0);
                }
            }
        }

        private void ShowTiles()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Image image = new Image();
                    image.MouseDown += new MouseButtonEventHandler(TileClick);
                    image.Source = tiles[j * cols + i].Show();
                    image.Tag = j * cols + i;
                    Grid.SetColumn(image, j);
                    Grid.SetRow(image, i);
                    grid.Children.Add(image);
                }
            }
        }

        public void Initialize()
        {
            for (int i = 0; i < rows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }

            for (int i = 0; i < cols; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
        }

        private List<ImageSource> GetImageList()
        {
            List<ImageSource> images = new List<ImageSource>();

            for (int i = 0; i < (rows * cols); i++)
            {
                int imageNumber = i % 8 + 1;

                ImageSource image = new BitmapImage(new Uri("/Resources/mozaik/" + imageNumber + ".png", UriKind.Relative));
                images.Add(image);
            }

            //Randomizer
            Random random = new Random();
            for (int i = 0; i < (rows * cols); i++)
            {
                int r = random.Next(0, (rows * cols));
                ImageSource schaap = images[r];
                images[r] = images[i];
                images[i] = schaap;
            }

            return images;
        }
    }
}
