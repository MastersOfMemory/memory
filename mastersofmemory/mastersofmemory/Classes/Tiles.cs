using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace mastersofmemory.Classes
{
    class Tiles
    {
        private ImageSource front, back;
        private bool clicked, visible;

        public Tiles(ImageSource frontTile)
        {
            back = new BitmapImage(new Uri("/Resources/mozaik/kaart.png", UriKind.Relative));
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
                return back;
        }

        public void FlipToBack()
        {
            clicked = false;


        }

        public void MakeInvisible()
        {
            visible = false;


        }
    }
}
