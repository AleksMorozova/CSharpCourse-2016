using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_AbstractHandler_
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler handler = new DOCHandler();            

            string type;
            Console.Write("Enter your document type: ");
            type = Console.ReadLine();

            switch(type)
            {
                case"txt":
                    Console.WriteLine("Type: TXT");
                    handler=new TXTHandler();
                    handler.Create();
                    handler.Open();
                    handler.Change();
                    handler.Save();
                    break;
                case "doc":
                    Console.WriteLine("Type: DOC");
                    handler.Create();
                    handler.Open();
                    handler.Change();
                    handler.Save();
                    break;
                case "xml":
                    Console.WriteLine("Type: XML");
                    handler = new XMLHandler();
                    handler.Create();
                    handler.Open();
                    handler.Change();
                    handler.Save();
                    break;
                default:
                    Console.WriteLine("Can't find this type.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
