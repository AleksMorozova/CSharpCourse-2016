using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassRoom
{
    class Pupil : IPupil
    {
        public string Name { get; private set; }
        public Pupil(string name)
        {
            this.Name = name;
        }
        public virtual void Study()
        {
            Console.WriteLine("Pupil studying");
        }
        public virtual void Read()
        {
            Console.WriteLine("Pupil reading");
        }
        public virtual void Write()
        {
            Console.WriteLine("Pupil writing");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Pupil relaxing");
        }
    }
}
