using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4DocumentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ключ, если у вас не ключа нажмите \"Enter\": ");
            string key = Console.ReadLine();
            DocumentWorker documentWorker;
            if (key == "pro")
            {
                documentWorker = new ProDocumentWorker();
            }
            else if (key == "exp")
            {
                documentWorker = new ExpertDocumentWorker();               
            }
            else
            {
                documentWorker = new DocumentWorker();               
            }
            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();
        }
    }
}
