using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6_MiddleArifmeticRnd
{
    static class Generator
    {
        private static readonly Random rnd;
        private static readonly object syncLocker;
        static Generator()
        {
            rnd = new Random(DateTime.Now.Millisecond);
            syncLocker = new object();
        }
        public static int Generate(int min, int max)
        {
            lock(syncLocker)
            {
                return rnd.Next(min, max + 1);
            }
        }
    }
}
