using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassRoom
{
    class ClassRoom
    {
        private readonly Pupil[] pupils;
        public ClassRoom(Pupil pupil)
        {
            pupils = new Pupil[4];
            pupils[0] = pupil;
        }
        public ClassRoom(Pupil pupilFirst, Pupil pupilSecond) : this(pupilFirst)
        {
            pupils[1] = pupilSecond;
        }
        public ClassRoom(Pupil pupilFirst, Pupil pupilSecond, Pupil pupilThird) : this(pupilFirst, pupilSecond)
        {
            pupils[2] = pupilThird;
        }
        public ClassRoom(Pupil pupilFirst, Pupil pupilSecond, Pupil pupilThird, Pupil pupilFourth) : this(pupilFirst, pupilSecond, pupilThird)
        {
            pupils[3] = pupilFourth;
        }
        public void PrintClassInfo()
        {
            for (int i = 0; i < pupils.Count(); i++)
            {
                if (pupils[i] == null) break;
                Console.WriteLine("Pupil {0}:", pupils[i].Name);
                pupils[i].Study();
                pupils[i].Read();
                pupils[i].Write();
                pupils[i].Relax();
            }
        }
    }
}
