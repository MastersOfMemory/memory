using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace MastersofMemory.ViewModel
{
    public class TimerViewModel : ObservableObject
    {
        private DispatcherTimer _gameTimer; 
        private TimeSpan _playedTime;

        private const int _timerSeconds = 1;

        public TimeSpan Time        
        {
            get
            {
                return _playedTime;
            }
            set
            {
                _playedTime = value;
                OnPropertyChanged("Time");
            }
        }

        public TimerViewModel(TimeSpan time)
        {
            _gameTimer = new DispatcherTimer();
            _gameTimer.Interval = time;
            _gameTimer.Tick += GameTimer_Tick; 
            _playedTime = new TimeSpan();
        }

        public void Stop()
        {
            _gameTimer.Stop(); //Stopt de timer
        }

        public void Start()
        {
            _gameTimer.Start(); //Start de timer
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Time = _playedTime.Add(new TimeSpan(0, 0, 1));
        }     
    }
}
