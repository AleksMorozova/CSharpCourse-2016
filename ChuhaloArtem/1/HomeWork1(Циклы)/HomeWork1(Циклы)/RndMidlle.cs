using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_Циклы_
{
    class RndMidlle
    {
        public void Show()
        {
            Random rnd=new Random();
            double sr=0;
            int [] items = new int[5];

            for(int i=0;i<5;i++)
            {                
                items[i] = rnd.Next(1,20);
                Console.Write("\n{0}-е число: {1}", i + 1, items[i]);
                sr = sr + items[i];
            }
            Console.WriteLine("\nСреднее арифметическое: {0}", sr/5);
        }
    }
}
