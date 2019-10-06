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

namespace singlemultiPlayer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Start_Game_Click(object sender, RoutedEventArgs e)
        {
            string singlePlayer_Name = singlePlayer_Input.Text;
            string multiPlayer_Name = multiPlayer_Input.Text; 

            if (multiPlayer_Check.IsChecked == true) //If Multi Player is Enabled
            {
                if(string.IsNullOrEmpty(singlePlayer_Name)) {   //If First Player's Input is Empty
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
                    singlePlayer_Test.Content = singlePlayer_Name;
                    multiPlayer_Test.Content = multiPlayer_Name; //DEZE SHOWT NOG NIET OP!!!!!!!!!!!!!
                }
            }
            else if (multiPlayer_Check.IsChecked == false)  //If Multi Player Mode isn't Enabled
            {
                multiPlayer_Name = null;

                if(string.IsNullOrEmpty(singlePlayer_Name)) //First Player Input is Empty
                {
                    singlePlayer_Name = "Player1";
                    singlePlayer_Test.Content = singlePlayer_Name;
                }
            }
            singlePlayer_Name = Convert.ToString(singlePlayer_Test.Content);
            multiPlayer_Name = Convert.ToString(multiPlayer_Test.Content);
        }

        private void Backto_Menu_Click(object sender, RoutedEventArgs e)
        {
            singlePlayer_Test.Content = singlePlayer_Input.Text;
            multiPlayer_Test.Content = multiPlayer_Input.Text;
            singlePlayer_Input.Clear();
            multiPlayer_Input.Clear();
        }
    }
}
