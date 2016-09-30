using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_NumberRange
{
    class Program
    {
        static void Main(string[] args)
        {
            INumber number = new Number();
            Console.WriteLine("Enter the number, please:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The number has {0} ranges", number.GetRange(n));
            Console.ReadKey();
        }
    }
}
