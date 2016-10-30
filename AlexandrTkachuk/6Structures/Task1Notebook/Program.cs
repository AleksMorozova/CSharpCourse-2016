using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Notebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebookHP = new Notebook("HP", "Pavillion 15", 800); ;
            notebookHP.ShowInfo();
        }
    }
}
