using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4GoodAndBad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num == 1 ? "Хорошо" : num == 0 ? "Плохо" : "Непрвильный ввод");
        }
    }
}
