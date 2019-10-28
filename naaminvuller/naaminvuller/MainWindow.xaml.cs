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

namespace namechecker
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 


        }

        private void Button_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            string naamspeler1 = FirstPlayerInput.Text;
            string naamspeler2 = SecondPlayerInput.Text;
            
            //Als multiplayer wel is aangevinkt
            if (multiplayercheck.IsChecked == true)
            {
                if (string.IsNullOrEmpty(naamspeler1))
                {
                    naamspeler1 = "Speler 1";
                }

                if (naamspeler1.Contains("!") || naamspeler1.Contains("?"))
                {
                    Content = "Deze naam mag geen ! of ? bevatten";
                    return;
                }

                if (naamspeler1.Length > 10)
                {
                    WarningLabel.Content = "De naam mag niet langer zijn dan 10 letters";
                    return;
                }


                //SPELER2

                else if (string.IsNullOrEmpty(naamspeler2))
                {
                    naamspeler2 = "Speler 2";
                }

                if (naamspeler2.Contains("!") || naamspeler2.Contains("?"))
                {
                    return;
                }

                if (naamspeler1.Length > 10)
                {
                    return;
                }

                //Als Speler 1 en Speler 2 niet worden ingevuld

                else if (string.IsNullOrEmpty(naamspeler1) && string.IsNullOrEmpty(naamspeler2))
                {
                    naamspeler1 = "Speler 1";
                    naamspeler2 = "Speler 2";
                }
            }

            //Als multiplayer niet is aangevinkt 
            else if (multiplayercheck.IsChecked == false)
            {
                naamspeler2 = null;

                if (string.IsNullOrEmpty(naamspeler1))
                {
                    naamspeler1 = "Speler 1";
                }

            }



        }
    }
}
