using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_Task1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("550i", "Sony Ericson", 200);

            notebook.PrintInfo();
            Console.ReadKey();
        }
    }
}
