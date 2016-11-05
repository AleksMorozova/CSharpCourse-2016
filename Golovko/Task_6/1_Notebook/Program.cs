using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Notebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("G55", "ASUS", 2000);
            notebook.PrintInfo();
            Console.ReadKey();
        }
    }
}
