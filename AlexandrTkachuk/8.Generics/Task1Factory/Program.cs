using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i1 = MyClass<int>.FactoryMethod();
            char ch = MyClass<char>.FactoryMethod();
            DateTime dt = MyClass<DateTime>.FactoryMethod();
        }

        class MyClass<T> where T: new()
        {
            public static T FactoryMethod()
            {
                return new T();
            }
        }
    }
}
