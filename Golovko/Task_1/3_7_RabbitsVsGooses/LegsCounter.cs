using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_7_RabbitsVsGooses
{
    class LegsCounter : IlegsCounter
    {
        private readonly int count;
        public LegsCounter(int count)
        {
            this.count = count;
        }
        public void GetLegsCount()
        {
            for (int i = 0; i <= count; i++)
            {
                for (int j = 0; j <= count; j++)
                {
                    if (2 * i + 4 * j == count)
                    {
                        Console.WriteLine("{0} gooses and {1} rabbits", i, j);
                    }
                }
            }
        }
    }
}
