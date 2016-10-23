using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            GoodPupil pupil1 = new GoodPupil();
            BadPupil pupil2 = new BadPupil();
            GoodPupil pupil3 = new GoodPupil();
            ExcelentPupil pupil4 = new ExcelentPupil();
            ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
            classRoom.ShowPupilsInformation();
        }
    }
}
