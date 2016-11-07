using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_DelegatesArray
{
    class AvgCalculator
    {
        public static AvgDelegate Avg = (rndDelegateArray =>
        {
            double sum = 0;
            foreach (RndDelegate rndDelegate in rndDelegateArray)
            {
                sum += rndDelegate();
            }
            return sum / rndDelegateArray.Length;
        });
    }
}
