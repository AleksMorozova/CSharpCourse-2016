using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Taxi
    {
        public void Function()
        {
            int sum = 0;
            Console.Write("\nKilometrs: ");
            int km = int.Parse(Console.ReadLine());
            Console.Write("\nMinutes: ");
            int stop = Convert.ToInt32(Console.ReadLine());

            if (km < 0 || stop < 0)
            {
                Console.WriteLine("\nInvalid selection. Please select corect item");
            }
            else
                if (km <= 5)
                    sum = 20 + stop;
                else
                    sum = 20 + stop + (km - 5) * 3;

            Console.WriteLine("\nYour check: " + sum + "grn. Thank you!");
        }
    }
}
