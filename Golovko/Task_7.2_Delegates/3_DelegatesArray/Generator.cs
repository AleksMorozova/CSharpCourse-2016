using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_DelegatesArray
{
    static class Generator
    {
        private const int MaxValue = 100;
        private static readonly object locker;
        private static readonly Random rnd;
        static Generator()
        {
            locker = new object();
            rnd = new Random(DateTime.Now.Millisecond);
        }
        public static int GetRand()
        {
            lock(locker)
            {
                int res = rnd.Next(MaxValue + 1);
                Log.Write("Generated: {0}", res);
                return res;
            }
        }
    }
}
