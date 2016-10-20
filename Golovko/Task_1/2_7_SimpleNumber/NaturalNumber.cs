using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7_SimpleNumber
{
    class NaturalNumber : INaturalNumber
    {
        public int Number {get; set;}
        public NaturalNumber(int number)
        {
            this.Number = number;
        }
        public bool IsSimple()
        {
            bool isSimple = true;
            for (int i = 2; i < Number / 2; i++)
            {
                if (Number % i == 0)
                {
                    isSimple = false;
                    break;
                }
            }
            return isSimple;
        }
    }
}
