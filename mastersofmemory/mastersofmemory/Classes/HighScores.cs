using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastersofmemory.Classes
{

    //Developers: Joeke de Graaf, Ynte Kuipers, Dirk van Houten
    class HighScores
    {
        public int Score;
        public int addScore = 50;
        public int decScore = 15;

        public void AddScore()
        {
            Score += addScore;
        }

        public void DecScore()
        {
            Score -= decScore;
        }
    }

   
}
