using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> myClass = new MyClass<int>();
            Console.WriteLine(myClass.FactoryMethod());
            Console.ReadLine();
        }
    }
}
