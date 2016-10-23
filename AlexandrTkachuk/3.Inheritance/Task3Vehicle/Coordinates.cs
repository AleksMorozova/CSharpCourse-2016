using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Vehicle
{
    class Coordinates
    {
        int x;
        int y;


        public int X
        {
            get { return x; }
        }
        
        public int Y
        {
            get { return y; }
        }


        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


    }
}
