using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_NumberRange
{
    class Number : INumber
    {
        public int GetRange(int number)
        {
            int range = 0;
            while (Math.Truncate((decimal)(number / Math.Pow(10, ++range))) > 0) ;
            return range;
        }
    }
}
