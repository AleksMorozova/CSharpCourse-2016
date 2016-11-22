using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_3_MyClass
{
    struct MyStruct
    {
        public string change;
    }
    class MyClass
    {
        public string change;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct myStruct;
            myStruct.change = "not changed";

            MyClass myClass = new MyClass();
            myClass.change = "not changed";

            Console.WriteLine("myClass.change:\t\t" + myClass.change);
            Console.WriteLine("myStruct.change:\t" + myStruct.change);
            Console.WriteLine();

            StructTaker(myStruct);
            ClassTaker(myClass);

            Console.WriteLine("myClass.change:\t\t" + myClass.change);
            Console.WriteLine("myStruct.change:\t" + myStruct.change);

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
