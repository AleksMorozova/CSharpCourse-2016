using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1DocumentsTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a type of document ");
            Console.Write("(XML - 1, TXT - 2, DOC - 3): ");
            int typeOfDocument = Convert.ToInt32(Console.ReadLine());
            AbstractHandler document = DetermineTypeOfDocument(typeOfDocument);
            InvokeMethodsOfThisType(document);
        }

        static AbstractHandler DetermineTypeOfDocument(int typeOfDocument)
        {
            AbstractHandler document;

            switch (typeOfDocument)
            {
                case 1:
                    document = new XMLHandler();
                    break;
                case 2:
                    document = new TXTHandler();
                    break;
                case 3:
                    document = new DOCHandler();
                    break; 
                default:
                    document = new TXTHandler();
                    Console.WriteLine("Incorrect type!");
                    Environment.Exit(1);
                    break;
            }
            return document;
        }

        static void InvokeMethodsOfThisType(AbstractHandler document)
        {
            document.Create();
            document.Open();
            document.Change();            
            document.Save();
        }
    }
}
