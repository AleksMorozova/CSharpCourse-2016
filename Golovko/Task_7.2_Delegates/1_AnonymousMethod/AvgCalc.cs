using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AnonymousMethod
{
    class AvgCalc
    {
        public static AvgDelegate Avg = (a, b, c) => (double)(a + b + c) / 3;
    }
}
