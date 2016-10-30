using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3MyClassAndMyStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.change = "unchanged";
            
            MyStruct myStruct = new MyStruct();
            myStruct.change = "unchanged";

            Console.WriteLine("Before method Taker: ");
            Console.WriteLine("myStruct.change = " + myStruct.change);
            Console.WriteLine("myClass.change = " + myClass.change);
            ClassTaker(myClass);
            StructTaker(myStruct);
            Console.WriteLine();
            Console.WriteLine("After method Taker:");           
            Console.WriteLine("myStruct.change = " + myStruct.change);
            Console.WriteLine("myClass.change = " + myClass.change);
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
