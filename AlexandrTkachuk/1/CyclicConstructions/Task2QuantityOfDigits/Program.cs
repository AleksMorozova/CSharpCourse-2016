using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2QuantityOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число : ");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());
            int number = enteredNumber;
            int count = 0;
            while (number > 0)
            {
                number = number / 10;
                count++;
            }
            if (count == 1)
            {
                Console.WriteLine("Число " + enteredNumber + " имеет " + count + " разряд");
            }
            else if (count >= 2 && count <= 4)
            {
                Console.WriteLine("Число " + enteredNumber + " имеет " + count + " разряда");
            }
            else
            {
                Console.WriteLine("Число " + enteredNumber + " имеет " + count + " разрядов");
            }
        }
    }
}
