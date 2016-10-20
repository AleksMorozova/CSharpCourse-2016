using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_MultiplyTable
{
    class MultiplyTable : IMultiplyTable
    {
        private readonly int range;
        public MultiplyTable(int range)
        {
            this.range = range;
        }
        public void ToBuild(int multiplier)
        {
            for (int i = 1; i <= range; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, multiplier, i * multiplier);
            }
        }
    }
}
