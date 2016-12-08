using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            foreach (int num in myClass.GetEvenNumbers(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }))
            {
                Console.WriteLine(num);
            }
        }
    }
}
