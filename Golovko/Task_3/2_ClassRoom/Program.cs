using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom(new ExcelentPupil("Walter"), new BadPupil("Dean"), new GoodPupil("Dick"), new GoodPupil("Alex"));
            classRoom.PrintClassInfo();
            Console.ReadKey();
        }
    }
}
