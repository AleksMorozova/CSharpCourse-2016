using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_8_Loto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ставка: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int temp;
            temp = rand.Next(1, 13);
            Console.WriteLine("Число на кубике: {0}", temp);
            if(temp > 0 && temp < 6)
                Console.WriteLine("Ваш выигрыш: {0}", 0);
            else if(temp > 5 && temp < 9)
                Console.WriteLine("Ваш выигрыш: {0}", a);
            else if(temp > 8 && temp < 12)
                Console.WriteLine("Ваш выигрыш: {0}", a*2);
            else Console.WriteLine("Ваш выигрыш: {0}", a*10);
            Console.ReadKey();
        }
    }
}
