using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_8_Lottery
{
    class Cube : ICube
    {
        private readonly int grainsCount;
        public Cube(int grainsCount)
        {
            this.grainsCount = grainsCount;
        }
        public int Throw()
        {
            return Generator.Generate(1, grainsCount);
        }
    }
}
