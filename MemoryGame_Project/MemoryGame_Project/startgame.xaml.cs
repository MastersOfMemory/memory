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
using Microsoft.Win32;

namespace MemoryGame_Project
{
    public partial class startgame : Page
    {
        public startgame()
        {
            InitializeComponent();
        }
        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            string singlePlayer_Name = singlePlayer_Input.Text;
            string multiPlayer_Name = multiPlayer_Input.Text;

            if (multiPlayer_Check.IsChecked == true) //If Multi Player is Enabled
            {
                if (string.IsNullOrEmpty(singlePlayer_Name)) //If First Player's Input is Empty
                {
                    singlePlayer_Name = "Player1"; //Default singlePlayer_Name value if user didn't type his name
                }
                else if (string.IsNullOrEmpty(multiPlayer_Name)) //If Second Player's Input is Empty
                {
                    multiPlayer_Name = "Player2"; //Default multiPlayer_Name value if user didn't type his name
                }
                else if (string.IsNullOrEmpty(singlePlayer_Name) && string.IsNullOrEmpty(multiPlayer_Name)) //If both First and Second Player's Input is Empty
                {
                    singlePlayer_Name = "Player1"; //Default singlePlayer_Name value if user didn't type his name
                    multiPlayer_Name = "Player2"; //Default multiPlayer_Name value if user didn't type his name
                    //singlePlayer_Test.Content = singlePlayer_Name;
                    //multiPlayer_Test.Content = multiPlayer_Name; //DEZE SHOWT NOG NIET OP!!!!!!!!!!!!!
                }
            }
            else if (multiPlayer_Check.IsChecked == false)  //If Multi Player Mode isn't Enabled
            {
                multiPlayer_Name = null;

                if (string.IsNullOrEmpty(singlePlayer_Name)) //First Player Input is Empty
                {
                    singlePlayer_Name = "Player1";
                }
            }

            App.ParentWindowRef.ParentFrame.Navigate(new playfield());
        }

        private void BackToMenu_Click(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.ParentFrame.Navigate(new menu());
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
