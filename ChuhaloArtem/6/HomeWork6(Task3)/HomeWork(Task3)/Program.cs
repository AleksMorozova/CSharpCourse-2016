using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Task3_
{
    class Program
    {
        static void ClassTaker(MyClass myclass)
        {
            myclass.change = "Changed";
        }

        static void StructTaker(MyStruct mystruct)
        {
            mystruct.change = "Changed";
        }
        
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass() { change = "Not chenged" };
            MyStruct mystruct = new MyStruct() { change = "Not changed" };

            ClassTaker(myclass);
            StructTaker(mystruct);

            Console.WriteLine("Class: {0}.", myclass.change);
            Console.WriteLine("Struct: {0}.", mystruct.change);
            Console.ReadKey();
        }        
    }
}
