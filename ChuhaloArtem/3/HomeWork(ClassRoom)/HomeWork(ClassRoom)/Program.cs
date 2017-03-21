using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_ClassRoom_
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classroom = new ClassRoom(new Pupil("Alla"), new BadPupil("Lisa"), new GoodPupil("Sasha"), new ExcelentPupil("Artem"));

            classroom.PrintInfo();
            Console.ReadKey();
        }
    }
}
