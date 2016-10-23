using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2ClassRoom
{
    class BadPupil: Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad study");
        }
        public override void Read()
        {
            Console.WriteLine("Bad read");
        }
        public override void Write()
        {
            Console.WriteLine("Bad write");
        }
        public override void Relax()
        {
            Console.WriteLine("Bad relax");
        }
    }
}
