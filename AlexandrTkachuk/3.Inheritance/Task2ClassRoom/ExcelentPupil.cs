using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2ClassRoom
{
    class ExcelentPupil: Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excelent study");
        }
        public override void Read()
        {
            Console.WriteLine("Excelent read");
        }
        public override void Write()
        {
            Console.WriteLine("Excelent write");
        }
        public override void Relax()
        {
            Console.WriteLine("Excelent relax");
        }      
    }
}
