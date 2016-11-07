using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Simple
    {
        public void Function()
        {
            Console.Write("\nEnter number: ");            
            int yournumberint = Convert.ToInt32(Console.ReadLine());
            double yournumberdob=yournumberint;
            int i = 2;
            bool des = true;

            while(i<yournumberint)
            {
                if (yournumberint / i == yournumberdob/i || yournumberdob % 2 == 0)
                {                   
                    des = false;
                    break;
                }
                else
                {
                    i++;
                }                
            }
            if (des==true)
            {
                Console.WriteLine("{0} - простое число.", yournumberint);               
            }
            else
            {
                Console.WriteLine("{0} - не простое число.", yournumberint);
            }
        }
    }
}
