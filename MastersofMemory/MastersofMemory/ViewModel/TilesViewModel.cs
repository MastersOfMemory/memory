using System;
using MastersofMemory.Models;
using System.Windows.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastersofMemory.ViewModel
{
    public class TilesViewModel : ObservableObject
    {
        private TilesModel _model;

        public int Id { get; private set; }

        private bool _viewed;
        private bool _matched;
        private bool _failed;

        public bool Viewed
        {
            get
            {
                return _viewed;
            }
            private set
            {
                _viewed = value;
                OnPropertyChanged("TileImage");
                OnPropertyChanged("BorderBrush");
            }
        }

        public bool Matched
        {
            get
            {
                return _matched;
            }
            private set
            {
                _matched = value;
                OnPropertyChanged("TileImage");
                OnPropertyChanged("BorderBrush");
            }
        }

        public bool Selectable  //Zorgt ervoor dat de tile te selecteren is
        {
            get
            {
                if (Viewed)    
                    return false; //Als de tile open gekanteld is, dan is deze niet meer selecteerbaar, vandaar dat selectable = false wordt aangegeven
                if (Matched)
                    return false; //Als 2 tiles met elkaar matchen, dan zijn alle tiles niet meer selecteerbaar, vandaar selectable = false

                return true;
            }
        }

        public bool Failed
        {
            get
            {
                return _failed;
            }
            private set
            {
                _failed = value;
                OnPropertyChanged("TileImage");
                OnPropertyChanged("BorderBrush");
            }
        }

        public string TileImage
        {
            get
            {
                if (Matched)  
                    return _model.ImageSource; //Als de tiles matchen, blijven ze met de plaatjes zichtbaar liggen
                if (Viewed)
                    return _model.ImageSource; //Als een van de tiles open ligt, blijft die zo liggen

                return "/MastersofMemory;component/Resources/Tile_Back.jpg"; //Wanneer de tile niet bekeken wordt of er is geen match, dan draait de tile zich weer om en wordt de achterkant zichtbaar
            }
        }

        public Brush BorderBrush
        {
            get
            {
                if (Failed)
                    return Brushes.Red; //Als de tiles niet matchen met elkaar, wordt de border van de tile rood
                if (Matched)
                    return Brushes.Green; //Als de tiles met elkaar matchen, wordt de border van de tile groen
                if (Viewed)
                    return Brushes.Yellow; //Als een tile is aangeklikt, wordt de border van de tile geel

                return Brushes.Black; //Als geen van de bovenstaande heeft voorgedaan, dan blijft de border van de tile zwart
            }
        }

        public TilesViewModel(TilesModel model)
        {
            _model = model;
            Id = model.ID;
        }

        public void LabelMatched()
        {
            Matched = true;
        }

        public void LabelFailed()
        {
            Failed = true;
        }

        public void TileView()
        {
            Viewed = true;
            OnPropertyChanged("TileImage");
        }

        public void CloseView()
        {
            Viewed = false;
            Failed = false;
            OnPropertyChanged("Selectable");
            OnPropertyChanged("TileImage");
        }
    }
}
