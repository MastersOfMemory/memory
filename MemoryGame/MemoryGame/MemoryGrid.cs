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

namespace MemoryGame
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
            
        }

        //TODO: Fix de bug met kaarten over de achterkant van de kaart

        private void TileClick(Object sender, MouseButtonEventArgs e)
        {
            if(NumberOfClickedTiles < 2)
            {
                NumberOfClickedTiles++;
                Image image = (Image)sender;
                int index = (int)image.Tag;
                image.Source = null;
                tiles[index].Clicked();

                if (NumberOfClickedTiles == 2)
                {
                    //TODO bug fix controller kaartjes
                    if (tiles[previousTile].Show() == tiles[index].Show())
                    {
                        tiles[previousTile].MakeInvisible();
                        tiles[index].MakeInvisible();

                        MessageBox.Show("Goed!");

                    }
                    else
                    {
                        tiles[previousTile].FlipToBack();
                        tiles[index].FlipToBack();

                        MessageBox.Show("Fout!");
                    }

                    NumberOfClickedTiles = 0;

                }
                else
                    previousTile = index;
                ShowTiles();
            }
        }

        private void AddImages()
        {
            List<ImageSource> images = GetImageList();
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
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
                for (int j = 0; i < cols; j++)
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
            
            for(int i = 0; i < cols; i++)
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

                ImageSource image = new BitmapImage(new Uri("Icons/" + imageNumber + ".png", UriKind.Relative));

            }

            //Ranomizer
            Random random = new Random();
            for (int i = 0; i < (rows * cols); i++)
            {
                int r = random.Next(0, (rows * cols));
                ImageSource banaan = images[r];
                images[r] = images[i];
                images[i] = banaan;
            }

            return images;
        }
    }
}
