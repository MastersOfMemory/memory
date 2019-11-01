using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MemoryGame
{
    class Tiles
    {
        private ImageSource front, back;
        private bool clicked, visible;

        public Tiles(ImageSource frontTile)
        {
            back = new BitmapImage(new Uri("Death-Star.png", UriKind.Relative));
            clicked = false;
            visible = true;
            front = frontTile;
        }

        public void Clicked()
        {
            clicked = true;
        }

        public ImageSource Show()
        {
            if (visible)
            {
                if (clicked)
                {
                    return front;
                }
                else
                    return back;
            }
            else
                return null;
        }

        public void FlipToBack()
        {
            clicked = false;
            visible = true;
        }

        public void MakeInvisible()
        {
            visible = false;
        }
    }
}
