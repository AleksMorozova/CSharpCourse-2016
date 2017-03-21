using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_ClassRoom_
{
    class Pupil
    {
        public string Name { get; private set; }
        public Pupil(string name)
        {
            this.Name = name;
        }
        public virtual void Study()
        {
            Console.WriteLine("{0} studying", Name);
        }
        public virtual void Read()
        {
            Console.WriteLine("{0} reading", Name);
        }
        public virtual void Write()
        {
            Console.WriteLine("{0} writing", Name);
        }
        public virtual void Relax()
        {
            Console.WriteLine("{0} relaxing", Name);
        }
    }
}
