using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4_SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the limit of square numbers:");
            int limit = int.Parse(Console.ReadLine());
            ISquareNumber squares = new SquareNumber(limit);
            squares.GetSquares();
            Console.ReadKey();
        }
    }
}
