using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassRoom
{
    class BadPupil : Pupil
    {
        public BadPupil(string name) : base(name) { }
        public override void Study()
        {
            Console.WriteLine("Pupil studies bad");
        }
        public override void Read()
        {
            Console.WriteLine("Pupil doesn't read");
        }
        public override void Write()
        {
            Console.WriteLine("Pupil doesn't write");
        }
        public override void Relax()
        {
            Console.WriteLine("Pupil relax a lot");
        }
    }
}
