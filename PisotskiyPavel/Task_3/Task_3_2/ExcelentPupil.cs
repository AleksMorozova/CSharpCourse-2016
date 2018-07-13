using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_2
{
    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string name) : base(name)
        {
        }

        public override void Read()
        {
            Console.WriteLine("{0} - отлично читает", Name);
        }

        public override void Relax()
        {
            Console.WriteLine("{0} - читает книги", Name);
        }

        public override void Study()
        {
            Console.WriteLine("{0} - отлично учится", Name);
        }

        public override void Write()
        {
            Console.WriteLine("{0} - отлично пишет", Name);
        }
    }
}
