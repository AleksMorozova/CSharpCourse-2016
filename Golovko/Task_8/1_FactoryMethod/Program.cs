using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            object exception = MyClass<Exception>.FactoryMethod();
            object @object = MyClass<object>.FactoryMethod();
            object @int = MyClass<int>.FactoryMethod();
            Console.WriteLine("Instance of type {0}", exception.GetType().Name);
            Console.WriteLine("Instance of type {0}", @object.GetType().Name);
            Console.WriteLine("Instance of type {0}", @int.GetType().Name);
            Console.ReadKey();
        }
    }
}
