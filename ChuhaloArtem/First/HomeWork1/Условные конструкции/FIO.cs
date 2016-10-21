using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class FIO
    {
        public void Print()
        {
            string surname;
            string name;
            string secname;
            string i;

            Console.WriteLine("\nPrint author FIO? y/n : ");
            i = Console.ReadLine();

            if (i == "y")
            {
                Console.WriteLine("+-------------------------+\n|Chuhalo Artem Ruslanovich|\n+-------------------------+");
            }

            Console.WriteLine("Print ayour FIO? y/n : ");
            i = Console.ReadLine();
            if (i == "y")
            {
                Console.WriteLine("Enter your surname: ");
                surname = Console.ReadLine();
                Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter your second name: ");
                secname = Console.ReadLine();

                Console.WriteLine("+-------------------------+\n|{0} {1} {2}|\n+-------------------------+", surname, name, secname);
                Console.ReadKey();
            }
        }
    }
}
