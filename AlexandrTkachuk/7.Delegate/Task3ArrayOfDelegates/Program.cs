using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3ArrayOfDelegates
{ 
    
    class Program
    {
        delegate int RandomDelegate();
        delegate int AverageDelegate(RandomDelegate[] delegates);
       
        static Random randomValue = new Random();

        static void Main(string[] args)
        {
            RandomDelegate randomDelegate1 = () => { return randomValue.Next(1,200); };
            RandomDelegate randomDelegate2 = () => { return randomValue.Next(1, 200); };
            RandomDelegate randomDelegate3 = () => { return randomValue.Next(1, 200); };

            RandomDelegate[] delegates = { randomDelegate1, randomDelegate2, randomDelegate3 };

            Console.WriteLine("Average value: "+ CalculateAverageValue(delegates));
        }        

        static AverageDelegate  CalculateAverageValue = delegate(RandomDelegate[] delegates)
        {
            int result = 0;
            foreach (RandomDelegate rd in delegates)
            {
                result += rd();
            }
            return result/delegates.Length;
        };
    }
}
