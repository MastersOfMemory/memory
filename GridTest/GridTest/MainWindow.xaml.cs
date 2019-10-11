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

namespace GridTest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlayField_Clear() //Een functie om het spelveld te resetten 
        {
            playfield.RowDefinitions.Clear();
            playfield.ColumnDefinitions.Clear();
        }

        private void Grid_Aanpassen_Click(object sender, RoutedEventArgs e) //Deze Click Event komt uiteindelijk bij de features.xaml
        {
            string GridSelection;

            if (Grid_Selection.SelectedValue == null)
                GridSelection = "";
            else
                GridSelection = Grid_Selection.SelectedValue.ToString(); //Hoe kan ik dit met NULL door laten gaan??
            
            if (GridSelection.Contains("16 (4x4)"))  
            {
                PlayField_Clear();

                for (int i = 0; i < 4; i++) //i = 4, vanwege een grid van 4 x 4
                {
                    playfield.RowDefinitions.Add(new RowDefinition());
                    playfield.ColumnDefinitions.Add(new ColumnDefinition());
                }
            }
            else if (GridSelection.Contains("36 (6x6)"))
            {
                PlayField_Clear();

                for (int i = 0; i < 6; i++)
                {
                    playfield.RowDefinitions.Add(new RowDefinition());
                    playfield.ColumnDefinitions.Add(new ColumnDefinition());
                }
            } 

            Console.WriteLine(GridSelection);
        }
    }
}
