using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom(new BadPupil("Philip Guzman"), new GoodPupil("Sean Luna"), new GoodPupil("Ben Harris"), new ExcelentPupil("Chris Bradley"));

            foreach (Pupil pupil in classRoom.Pupils)
            {
                pupil.Read();
                pupil.Write();
                pupil.Study();
                pupil.Relax();
                Console.WriteLine(new string('-', Console.BufferWidth - 1));
            }

            Console.ReadLine();
        }
    }
}
