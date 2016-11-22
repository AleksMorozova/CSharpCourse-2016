using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_MyClassMyStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass() { change = "unchanged" };
            MyStruct myStruct = new MyStruct() { change = "unchanged" };
            ClassTaker(myClass);
            StructTaker(myStruct);
            Console.WriteLine("Class change value = {0}", myClass.change);
            Console.WriteLine("Struct change value = {0}", myStruct.change);
            Console.ReadKey();
        }
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "changed";
        }
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "changed";
        }
    }
}
