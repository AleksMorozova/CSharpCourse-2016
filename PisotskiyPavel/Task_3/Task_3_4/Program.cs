using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите лицензионный ключ: ");
            string key = Console.ReadLine();
            DocumentWorker doc = GetDocumentWorker(key);
            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();

            Console.ReadLine();
        }

        static DocumentWorker GetDocumentWorker(string key)
        {
            DocumentWorker doc;

            switch (key.ToLower())
            {
                case "pro": doc = new ProDocumentWorker(); break;
                case "exp": doc = new ExpertDocumentWorker(); break;
                default: doc = new DocumentWorker(); break;
            }

            return doc;
        }
    }
}
