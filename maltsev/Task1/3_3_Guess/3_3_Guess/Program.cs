using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_3_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rand = new Random();
            int value = rand.Next(1, 147);
            Console.Write("Число от 1 до 146: ");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a != value)
            {
                if( a < value)Console.WriteLine("Выберите больше!");
                if (a > value) Console.WriteLine("Выберите меньше!");
                a = Convert.ToInt32(Console.ReadLine());
            }
            if(a == value) Console.WriteLine("Число отгадано!");
            Console.ReadKey();
        }
    }
}
