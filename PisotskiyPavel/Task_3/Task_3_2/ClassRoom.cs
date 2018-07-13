using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_2
{
    class ClassRoom
    {
        private readonly Pupil[] pupils = new Pupil[4];

        public IEnumerable<Pupil> Pupils
        {
            get
            {
                return pupils.Where(p => p != null);
            }
        }

        public ClassRoom(Pupil pupilFirst, Pupil pupilSecond, Pupil pupilThird, Pupil pupilFourth)
            : this(pupilFirst, pupilSecond, pupilThird)
        {
            pupils[3] = pupilFourth;
        }

        public ClassRoom(Pupil pupilFirst, Pupil pupilSecond, Pupil pupilThird)
            : this(pupilFirst, pupilSecond)
        {
            pupils[2] = pupilThird;
        }

        public ClassRoom(Pupil pupilFirst, Pupil pupilSecond)
        {
            pupils[0] = pupilFirst;
            pupils[1] = pupilSecond;
        }
    }
}
