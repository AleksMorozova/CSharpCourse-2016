using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass() { change = "Не изменено" };
            MyStruct myStruct = new MyStruct() { change = "Не изменено" };

            ClassTaker(myClass);
            StructTaker(myStruct);

            Console.WriteLine("{0} - {1}", myClass.GetType().Name, myClass.change);
            Console.WriteLine("{0} - {1}", myStruct.GetType().Name, myStruct.change);

            Console.ReadLine();
        }

        private static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        private static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
    }
}
