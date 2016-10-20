using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AbstractHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the document format, please (for example .txt): ");
            AbstractHandler handler = DocumentFormat.GetHandler(Console.ReadLine());
            if (handler != null)
            {
                handler.Open();
                handler.Create();
                handler.Change();
                handler.Save();
            }
            else
            {
                Console.WriteLine("Unknown document format");
            }
            Console.ReadKey();
        }
    }
}
