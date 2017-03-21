using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class ThreeOp
    {
        public void Operation()
        {
            string output;

            Console.Write("\nPrint 1 or 0: ");
            int input = int.Parse(Console.ReadLine());
            output = (input == 1) ? "Хорошо" : "Плохо";
            Console.WriteLine(output);

            if (input != 1 && input != 0)
                Console.WriteLine("\nInvalid selection. Please select proposed item");
        }
    }
}
