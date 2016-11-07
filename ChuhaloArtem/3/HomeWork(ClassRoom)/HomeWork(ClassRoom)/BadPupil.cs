using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_ClassRoom_
{
    class BadPupil:Pupil
    {
        public BadPupil(string name) : base(name) { }

        public override void Study()
        {
            Console.WriteLine("\n" + Name+" studies bad");
        }
        public override void Read()
        {
            Console.WriteLine(Name+" doesn't read");
        }
        public override void Write()
        {
            Console.WriteLine(Name+" doesn't write");
        }
        public override void Relax()
        {
            Console.WriteLine(Name+" relax a lot");
        }
    }
}
