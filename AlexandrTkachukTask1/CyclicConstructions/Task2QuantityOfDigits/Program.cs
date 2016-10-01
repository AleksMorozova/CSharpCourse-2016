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
            int enteredNum = Convert.ToInt32(Console.ReadLine());
            int num = enteredNum;
            int count = 0;
            while (num > 0)
            {
                num = num / 10;
                count++;
            }
            if (count == 1)
            {
                Console.WriteLine("Число " + enteredNum + " имеет " + count + " разряд");
            }
            else if (count >= 2 && count <= 4)
            {
                Console.WriteLine("Число " + enteredNum + " имеет " + count + " разряда");
            }
            else
            {
                Console.WriteLine("Число " + enteredNum + " имеет " + count + " разрядов");
            }
        }
    }
}
