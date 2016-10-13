using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_Циклы_
{
    class Table
    {
        public void Function()
        {
            Console.Write("\nEnter item: ");
            double number = Convert.ToDouble(Console.ReadLine());

            for(int i=1;i<=10;i++)
            {
                Console.Write(" {1} \n {0} ", number*i, i);
            }
        }
    }
}
