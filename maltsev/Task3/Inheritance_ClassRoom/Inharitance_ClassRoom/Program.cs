using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_ClassRoom
{
    class ClassRoom
    {
        public ClassRoom(Pupil[] pupils)
        {
            if (pupils.Length >= 2 && pupils.Length <= 4)
            {
                foreach (var item in pupils)
                {
                    item.Study();
                    item.Read();
                    item.Write();
                    item.Relax();
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("Error");
        }
    }
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Pupil.Study");
        }
        public virtual void Read()
        {
            Console.WriteLine("Pupil.Read");
        }
        public virtual void Write()
        {
            Console.WriteLine("Pupil.Write");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Pupil.Relax");
        }
    }
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("ExcelentPupil.Study");
        }
        public override void Read()
        {
            Console.WriteLine("ExcelentPupil.Read");
        }
        public override void Write()
        {
            Console.WriteLine("ExcelentPupil.Write");
        }
        public override void Relax()
        {
            Console.WriteLine("ExcelentPupil.Relax");
        }
    }
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("GoodPupil.Study");
        }
        public override void Read()
        {
            Console.WriteLine("GoodPupil.Read");
        }
        public override void Write()
        {
            Console.WriteLine("GoodPupil.Write");
        }
        public override void Relax()
        {
            Console.WriteLine("GoodPupil.Relax");
        }
    }
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("BadPupil.Study");
        }
        public override void Read()
        {
            Console.WriteLine("BadPupil.Read");
        }
        public override void Write()
        {
            Console.WriteLine("BadPupil.Write");
        }
        public override void Relax()
        {
            Console.WriteLine("BadPupil.Relax");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pupil[] pupils = new Pupil[4];
            pupils[0] = new ExcelentPupil();
            pupils[1] = new ExcelentPupil();
            pupils[2] = new GoodPupil();
            pupils[3] = new BadPupil();
            ClassRoom cl = new ClassRoom(pupils);
            Console.ReadKey();
        }
    }
}
