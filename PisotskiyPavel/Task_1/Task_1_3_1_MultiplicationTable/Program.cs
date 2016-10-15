using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_3_1_MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для умножения: ");
            int multiplier = Convert.ToInt32(Console.ReadLine());
            DisplayMultiplicationTable(multiplier);
            Console.ReadLine();
        }

        static void DisplayMultiplicationTable(int multiplier)
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", multiplier, i, multiplier * i);
            }
        }
    }
}
