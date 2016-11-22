using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_1
{
    class MyClass<T> where T: new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            char exz = MyClass<char>.FactoryMethod();
            int exz1 = MyClass<int>.FactoryMethod();
        }
    }
}
