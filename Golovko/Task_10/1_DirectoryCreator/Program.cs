using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.Create(@"D:\", "Folder", 100);
            Directory.Remove(@"D:\", "Folder", true);
            Console.ReadKey();
        }
    }
}
