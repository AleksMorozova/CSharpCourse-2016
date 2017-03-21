using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_DocumentWorker_
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker worker = new DocumentWorker();           
            
            string str=null;
            Console.Write("Enter your key(pro, exp): ");
            str = Console.ReadLine();

            switch(str)
            {
                case"pro":
                    worker = new ProDocumentWorker();
                    worker.OpenDocument();
                    worker.EditDocument();
                    worker.SaveDocument();
                    break;
                case"exp":
                    worker = new ExpertDocumentWorker();
                    worker.OpenDocument();
                    worker.EditDocument();
                    worker.SaveDocument();
                    break;
                default:
                    Console.WriteLine("You haven't key.");
                    worker.OpenDocument();
                    worker.EditDocument();
                    worker.SaveDocument();
                    break;
            }
            Console.ReadKey();
        }
    }
}
