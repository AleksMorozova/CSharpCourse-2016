using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_8_Lottery
{
    class Game : IGame
    {
        private const int grains = 12;
        private readonly ICube cube;
        public int Rate { get; }
        public Game(int rate)
        {
            this.Rate = rate;
            cube = new Cube(grains);
        }
        public string Play()
        {
            string result;
            int points = cube.Throw();
            if (points < 6) result = points + " points. You won 0 uah. Game over.";
            else if (points < 9) result = points + " points. You won " + Rate + " uah";
            else if (points < 12) result = points + " points. You won " + 2 * Rate + " uah";
            else result = points + " points. You won " + 10 * Rate + " uah";
            return result;
        }
    }
}
