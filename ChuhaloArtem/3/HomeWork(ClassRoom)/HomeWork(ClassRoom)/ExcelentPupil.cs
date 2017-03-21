using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_ClassRoom_
{
    class ExcelentPupil: Pupil
    {
        public ExcelentPupil(string name) : base(name) { }

        public override void Study()
        {
            Console.WriteLine("\n" + Name + " studies hard");
        }
        public override void Read()
        {
            Console.WriteLine(Name + " reads quickly");
        }
        public override void Write()
        {
            Console.WriteLine(Name + " writes a lot");
        }
        public override void Relax()
        {
            Console.WriteLine(Name + " doesn't relax");
        }
    }
}
