using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_DocumentWorker
{
    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
    class ProDocumentWorker: DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в " + 
                "остальных форматах доступно в версии Эксперт");
        }
    }
    class ExpertDocumentWorker: ProDocumentWorker
    {
         public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: exp");
            Console.WriteLine("2: pro");
            Console.WriteLine("3: no key");

            DocumentWorker worker = null;
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 1)
            {
                worker = new ExpertDocumentWorker();
            }
            else if (a == 2)
            {
                worker = new ProDocumentWorker();
            }
            else
            { 
                worker = new DocumentWorker();
            }
            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();
            
            Console.ReadKey();
        }
    }
}
