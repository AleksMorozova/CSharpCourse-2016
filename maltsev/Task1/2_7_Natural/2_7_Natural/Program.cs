using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_7_Natural
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0) count++;
            }
            if (count == 2 ) Console.WriteLine("Число {0} явл простым",a);
            else Console.WriteLine("Число {0} не явл простым", a);
            Console.ReadKey();
        }
    }
}
