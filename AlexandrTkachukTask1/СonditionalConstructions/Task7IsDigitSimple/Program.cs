using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7IsDigitSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = num / 2; i > 1; i--)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Число " + num + " не простое");
                    return;
                }

            }
            Console.WriteLine("Число " + num + " простое");
        }
    }
}
