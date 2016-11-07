using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassRoom
{
    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string name) : base(name){}
        public override void Study()
        {
            Console.WriteLine("Pupil studies hard");
        }
        public override void Read()
        {
            Console.WriteLine("Pupil reads a lot");
        }
        public override void Write()
        {
            Console.WriteLine("Pupil writes a lot");
        }
        public override void Relax()
        {
            Console.WriteLine("Pupil doesn't relax");
        }
    }
}
