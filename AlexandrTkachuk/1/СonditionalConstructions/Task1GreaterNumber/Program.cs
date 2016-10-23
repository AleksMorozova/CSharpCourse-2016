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
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число : ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int result = number1 > number2 ? number1 : number2;
            Console.WriteLine("Наибольшее число : " + result);
        }
    }
}
