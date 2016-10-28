using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Microsoft Surface Book i7", "Microsoft", 2400);
            notebook.PrintInfo();

            Console.ReadLine();
        }
    }
}
