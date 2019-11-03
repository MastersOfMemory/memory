using mastersofmemory.Classes;
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
using mastersofmemory.Pages;

namespace mastersofmemory.Pages
{
    public partial class playfield : Page
    {
        private MemoryGrid mgrid;

        public playfield()
        {
            InitializeComponent();
            mgrid = new MemoryGrid(GameGrid);
        }

        private void PlayFieldMenu_Click(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.ParentFrame.Navigate(new playfield_menu());
        }

        private void PlayFieldRetry_Click(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.ParentFrame.Navigate(new playfield());
        }
    }
}
