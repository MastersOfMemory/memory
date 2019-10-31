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
using System.Windows.Threading;

namespace Timer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer dt = new DispatcherTimer(); //Maakt de timer aan
            dt.Interval = TimeSpan.FromSeconds(1); //Aantal seconden waar de timer 1 af telt (Bij 5 zou het 5 seconden duren voor hij van 3 naar 2 gaat)
            dt.Tick += dtClock; // Code vanaf line 40
            dt.Start(); // Hier door start de timer
            
            
        }

        // Deze int is de tijd waar de timer mee begint
        private int TimerTime = 11;


        private void dtClock(object sender, EventArgs e)
        {
            TimerTime--;

            Timer.Content = TimerTime.ToString();

            //Dit is het stuk waar de code af telt.

            if (TimerTime > 0)
            {
                Timer.Content = "Je hebt nog " + TimerTime + " seconden om je zet te doen!";
                //Add code voor kaart omdraaien
            }

            //Als de timer 0 hit is de beurt van de speler voorbij. De timer word ook gereset naar 15
            if (TimerTime == 0)
            {
                Timer.Content = "10 seconden zijn voorbij, de volgende speler is aan de beurt.";
                TimerTime = 15;
                //Add code voor het niet omdraaien van kaarten
            }

            //Van 15-10 word dit nog gedisplayed en daarna begint de timer weer met aftellen
            if (TimerTime > 10)
            {
                Timer.Content = "10 seconden zijn voorbij, de volgende speler is aan de beurt.";
                //Add code voor het niet omdraaien van kaarten
            }

        }


        //Dit zou de button voor de volgende zet moeten zijn
        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
