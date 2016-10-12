using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_Циклы_
{
    class Natural
    {
        public void Show()
        {
            int i=1;
            Console.Write("\nEnter max item: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while(i < number)
            {
                Console.Write("\n {0} ", Math.Pow(i,2));
                i++;
            }
        }
    }
}
