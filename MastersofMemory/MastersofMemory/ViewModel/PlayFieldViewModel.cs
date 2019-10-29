using System;
using MastersofMemory.Models;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace MastersofMemory.ViewModel
{
    public class PlayFieldViewModel : ObservableObject
    {
        public ObservableCollection<TilesViewModel> TileCards { get; private set; }

        private TilesViewModel FirstTileSelected;
        private TilesViewModel SecondTileSelected;

        private DispatcherTimer _viewTimer;
        private DispatcherTimer _openTimer;
        private const int _viewSeconds = 3;
        private const int _openSeconds = 3;

        public bool Select { get; private set; }

        public bool TilesActive
        {
            get
            {
                if (FirstTileSelected == null || SecondTileSelected == null)
                    return true;

                return false;
            }
        }

        public bool TilesAllMatched
        {
            get
            {
                foreach(var tile in TileCards)
                {
                    if (!tile.Matched)
                        return false;
                }

                return true;
            }
        }

        public PlayFieldViewModel()
        {
            _viewTimer = new DispatcherTimer();
            _viewTimer.Interval = new TimeSpan(0, 0, _viewSeconds);
            _viewTimer.Tick += ViewTimer_Tick;

            _openTimer = new DispatcherTimer();
            _openTimer.Interval = new TimeSpan(0, 0, _openSeconds);
            _openTimer.Tick += OpenTimer_Tick;
        }

        public void CreateTiles(string imagePath)
        {
            TileCards = new ObservableCollection<TilesViewModel>();
            var models = GetModelsFrom(imagePath);

            for (int i = 0; i < 6; i++)
            {
                var newTile = new TilesViewModel(models[i]);
                var newMatchTile = new TilesViewModel(models[i]);
                TileCards.Add(newTile);
                TileCards.Add(newMatchTile);
                newTile.TileView();
                newMatchTile.TileView();
            }

            TileShuffle();
            OnPropertyChanged("TileCards");
        }

        public void SelectTile(TilesViewModel tile)
        {
            tile.TileView();

            if (FirstTileSelected == null)
                FirstTileSelected = tile;
            else if (SecondTileSelected == null)
            {
                SecondTileSelected = tile;
                UnmatchedHide();
            }

            //Sound FX flip Card
            OnPropertyChanged("TilesActive");
        }

        public bool MatchedCheck()
        {
            if (FirstTileSelected.Id == SecondTileSelected.Id)
            {
                CorrectMatch();
                return true;
            }
            else
            {
                IncorrectMatch();
                return false;
            }
        }

        private void CorrectMatch()
        {
            FirstTileSelected.LabelMatched();
            SecondTileSelected.LabelMatched();
            ClearSelectedTiles();
        }

        private void IncorrectMatch()
        {
            FirstTileSelected.LabelFailed();
            SecondTileSelected.LabelFailed();
            ClearSelectedTiles();
        }

        public void UnmatchedReveal()
        {
            foreach(var tile in TileCards)
            {
                if(!tile.Matched)
                {
                    _viewTimer.Stop();
                    tile.LabelFailed();
                    tile.TileView();
                }
            }
        } 

        public void UnmatchedHide()
        {
            _viewTimer.Start();
        }

        public void Memorize()
        {
            _openTimer.Start();
        }

        private void ClearSelectedTiles()
        {
            FirstTileSelected = null;
            SecondTileSelected = null;
            Select = false;
        }

        private void TileShuffle()
        {
            var random = new Random();

            for (int i = 0; i < 64; i++)
            {
                TileCards.Reverse();
                TileCards.Move(random.Next(0, TileCards.Count), random.Next(0, TileCards.Count));
            }
        }

        private void OpenTimer_Tick(object sender, EventArgs e)
        {
            foreach (var tile in TileCards) {
                tile.CloseView();
                Select = true;
            }
            OnPropertyChanged("TilesActive");
        }

        private void ViewTimer_Tick(object sender, EventArgs e)
        {
            foreach(var tile in TileCards)
            {
                if (!tile.Matched)
                {
                    tile.CloseView();
                    Select = true;
                }
            }
            OnPropertyChanged("TilesActive");
            _viewTimer.Stop();
        }

        private List<TilesModel> GetModelsFrom(string relativePath)
        {
            var models = new List<TilesModel>();
            var images = Directory.GetFiles(@relativePath, "*.jpg", SearchOption.AllDirectories);

            var id = 0;

            foreach(string i in images)
            {
                models.Add(new TilesModel() { ID = id, ImageSource = "/MastersofMemory;component/" + i });
                id++;
            }

            return models;
        }
    }
}
