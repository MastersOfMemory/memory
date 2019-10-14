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

namespace MemoryGame_Project
{
    public partial class highscores : Page
    {
        public highscores()
        {
            InitializeComponent();
        }

        private void BackToMenu_HighScores_Click(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.ParentFrame.Navigate(new menu());
        }

        string PlayerName = "Bob";
        string TileAmount = "36";
        string HighScores = "300";

        

    }
}
