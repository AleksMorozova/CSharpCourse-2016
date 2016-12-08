using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Yield
{
    class MyClass
    {

        public IEnumerable GetEvenNumbers(int[] numbers)
        {
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    yield return num;
                }
            }
        }

    }
}
