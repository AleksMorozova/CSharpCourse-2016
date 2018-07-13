using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_2
{
    class BadPupil : Pupil
    {
        public BadPupil(string name) : base(name)
        {
        }

        public override void Read()
        {
            Console.WriteLine("{0} - плохо пишет", Name);
        }

        public override void Relax()
        {
            Console.WriteLine("{0} - много отдыхает", Name);
        }

        public override void Study()
        {
            Console.WriteLine("{0} - не учит уроки", Name);
        }

        public override void Write()
        {
            Console.WriteLine("{0} - плохо читает", Name);
        }
    }
}
