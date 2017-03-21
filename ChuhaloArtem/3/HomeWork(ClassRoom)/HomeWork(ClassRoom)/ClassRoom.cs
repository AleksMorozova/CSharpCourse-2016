using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_ClassRoom_
{
    class ClassRoom
    {
        private Pupil[] pupils;

        public ClassRoom(Pupil pupil)
        {
            pupils = new Pupil[4];
            pupils[0] = pupil;
        }
        public ClassRoom(Pupil first, Pupil second) : this(first)
        {
            pupils[1] = second;
        }
        public ClassRoom(Pupil first, Pupil second, Pupil thrid) : this(first, second)
        {
            pupils[2] = thrid;
        }
        public ClassRoom(Pupil first, Pupil second, Pupil thrid, Pupil fourth) : this(first, second, thrid)
        {
            pupils[3] = fourth;
        }

        public void PrintInfo()
        {
            for (int i = 0; i < pupils.Count(); i++)
            {
                if (pupils[i] == null) break;
                pupils[i].Study();
                pupils[i].Read();
                pupils[i].Write();
                pupils[i].Relax();
            }
        }
    }
}
