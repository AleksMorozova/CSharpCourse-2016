using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_2
{
    class GoodPupil : Pupil
    {
        public GoodPupil(string name) : base(name)
        {
        }

        public override void Read()
        {
            Console.WriteLine("{0} - нормально читает", Name);
        }

        public override void Relax()
        {
            Console.WriteLine("{0} - в свободное время отдыхает", Name);
        }

        public override void Study()
        {
            Console.WriteLine("{0} - хорошо учится", Name);
        }

        public override void Write()
        {
            Console.WriteLine("{0} - нормально пишет", Name);
        }
    }
}
