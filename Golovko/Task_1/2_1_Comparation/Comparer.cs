using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_Comparation
{
    struct Comparer: IComparer
    {
        private readonly double a;
        private readonly double b;
        public double Max
        {
            get { return a > b ? a : b; }
        }
        public Comparer(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
    }
}
