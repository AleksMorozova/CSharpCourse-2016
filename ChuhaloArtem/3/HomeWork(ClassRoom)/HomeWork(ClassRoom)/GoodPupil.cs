using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_ClassRoom_
{
    class GoodPupil: Pupil
    {
        public GoodPupil(string name) : base(name) { }

        public override void Study()
        {
            Console.WriteLine("\n" + Name + " studies good");
        }
        public override void Read()
        {
            Console.WriteLine(Name + " quite a lot of reading");
        }
        public override void Write()
        {
            Console.WriteLine(Name + " quite a lot of writing");
        }
        public override void Relax()
        {
            Console.WriteLine(Name + " sometimes relaxs");
        }
    }
}
