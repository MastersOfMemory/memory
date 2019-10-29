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
            dt.Interval = TimeSpan.FromSeconds(1); //Aantal waar de timer mee op telt
            dt.Tick += dtTicker; //Verwijst naar de code in vanaf lijn 40
            dt.Start(); //Start de timer zo gauw het programma runned
        }

        // Deze int is de tijd waar de timer mee begint
        private int TimerTime = 11;
        private void dtTicker(object sender, EventArgs e)
        {
            TimerTime--;

            Timer.Content = TimerTime.ToString();

            //Bij 0 reset de timer naar 10

            if (TimerTime == 0) 
            {
                TimerTime = 11;
            }
        }

    }
}
