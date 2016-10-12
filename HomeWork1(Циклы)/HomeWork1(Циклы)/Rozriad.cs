using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_Циклы_
{
    class Rozriad
    {
        public void Print()
        {
            double output=0;
            Console.Write("\nEnter item: ");
            long item = Convert.ToInt32(Console.ReadLine());

            while (item != 0)
            {
                output++;
                item /= 10;
            }
            Console.WriteLine("{0}", output);
        }
    }
}
