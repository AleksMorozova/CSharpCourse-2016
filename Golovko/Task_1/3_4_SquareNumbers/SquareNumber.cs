using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4_SquareNumbers
{
    class SquareNumber : ISquareNumber
    {
        private readonly int limit;
        public SquareNumber(int limit)
        {
            this.limit = limit;
        }
        public void GetSquares()
        {
            int number = 1;
            int square;
            while ((square = (int)Math.Pow(++number, 2)) < limit)
            {
                Console.WriteLine("{0}^2 = {1}", number, square);
            }
        }
    }
}
