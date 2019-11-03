using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using mastersofmemory.Classes;
using Microsoft.Win32;

namespace mastersofmemory.Pages
{
    public partial class gameproperties : Page
    {
        public TextBox PlayerOneInput;
        public TextBox PlayerTwoInput;
        public CheckBox PlayerTwoCheck;
      
        public gameproperties()
        {
            InitializeComponent();
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.ParentFrame.Navigate(new Pages.playfield());
        }

        private void BackToMenu_Click(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.ParentFrame.Navigate(new Pages.menu());
        }

        private void Skins_Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog skins_OpenFileDialog = new OpenFileDialog();
            skins_OpenFileDialog.DefaultExt = ".png";
            skins_OpenFileDialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            Nullable<bool> skins_ShowFileDialog = skins_OpenFileDialog.ShowDialog();

            if (skins_ShowFileDialog == true)
            {
                string skins_fileName = skins_OpenFileDialog.FileName;
                //Nog niet klaar mee
            }
        }
    }
}
