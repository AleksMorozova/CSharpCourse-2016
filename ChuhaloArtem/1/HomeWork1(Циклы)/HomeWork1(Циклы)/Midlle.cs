using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_Циклы_
{
    class Midlle
    {
        public void Show()
        {
            double sr=0;
            int [] items = new int [5];

            for(int i=0;i<5;i++)
            {
                Console.Write("\nВведите {0}-е число: ", i + 1);
                items[i] = Convert.ToInt32(Console.ReadLine());
                sr = sr + items[i];
            }
            Console.WriteLine("\nСреднее арифметическое: {0}", sr/5);
        }
    }
}
