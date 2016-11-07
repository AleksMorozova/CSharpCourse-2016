using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_Циклы_
{
    class Animals
    {
        public void Show()
        {
            int legs = 64;
            int guses = 32;
            int rabbits = 0;

            do
            {
                Console.WriteLine("\nГусей - {0}, кроликов - {1}", guses, rabbits);
                rabbits++;
                guses -= 2;
            } while (guses >= 0);
        }
    }
}
