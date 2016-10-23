using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2ClassRoom
{
    class ClassRoom
    {
        List<Pupil> ListOfPupils;


        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            ListOfPupils = new List<Pupil>();
            ListOfPupils.Add(pupil1);
            ListOfPupils.Add(pupil2);
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3): this(pupil1, pupil2)
        {
            ListOfPupils.Add(pupil3);
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4): this(pupil1, pupil2, pupil3)
        {
            ListOfPupils.Add(pupil4);
        }

        public void ShowPupilsInformation()
        {
            int count = 1;            
            foreach (Pupil pupil in ListOfPupils)
            {
                Console.WriteLine("Information about pupil № " + count);
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
                count++;
                Console.WriteLine();
            }

        }
    }
}
