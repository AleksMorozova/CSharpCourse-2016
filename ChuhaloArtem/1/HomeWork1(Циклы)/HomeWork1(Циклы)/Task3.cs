using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_Циклы_
{
    class Task3
    {
        public void Ugadai()
        {
            Random rnd = new Random();

            int number = rnd.Next(1,146);
            int step;

            do
            {
                Console.Write("\nУгадывайте: ");
                step = Convert.ToInt32(Console.ReadLine());

                if (step < number)
                    Console.WriteLine("Нужно больше.");
                if (step > number)
                    Console.WriteLine("Перебор.");
            } while (step != number);
            Console.WriteLine("\nВы угадали!");
        }
    }
}
