using System;
using MastersofMemory.ViewModel;
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

namespace MastersofMemory.View
{
    public partial class GamePropertiesView : UserControl
    {
        public GamePropertiesView()
        {
            InitializeComponent();
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            var gameProperties = DataContext as StartViewModel;
            gameProperties.NewGame(Grid_Selection.SelectedIndex);
        }
    }
}
