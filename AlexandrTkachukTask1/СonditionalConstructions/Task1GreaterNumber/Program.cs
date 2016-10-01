using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 > num2 ? num1 : num2;
            Console.WriteLine("Наибольшее число : " + result);
        }
    }
}
