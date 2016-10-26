using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_2
{
    abstract class Pupil
    {
        public abstract void Study();
        public abstract void Write();
        public abstract void Read();
        public abstract void Relax();

        public string Name { get; set; }

        public Pupil(string name)
        {
            Name = name;
        }
    }
}
