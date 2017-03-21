using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_Task3_
{
    class Average
    {        
        private static Random rnd = new Random();

        public static int GetRnd()
        {
            return rnd.Next(1, 100);
        }

        public static AvgDelegate Avg = (rndDelegateArray =>
        {
            double sum = 0;
            foreach (RndDelegate rndDelegate in rndDelegateArray)
            {
                Console.WriteLine("Sum is: {0}", sum);
                sum += rndDelegate();
            }
            return sum / rndDelegateArray.Length;
        });
    }
}
