using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassRoom
{
    class GoodPupil : Pupil
    {
        public GoodPupil(string name) : base(name){}
        public override void Study()
        {
            Console.WriteLine("Pupil studies good");
        }
        public override void Read()
        {
            Console.WriteLine("Pupil usually reads");
        }
        public override void Write()
        {
            Console.WriteLine("Pupil usually writes");
        }
        public override void Relax()
        {
            Console.WriteLine("Pupil sometimes relaxs");
        }
    }
}
