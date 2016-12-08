using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4DocumentWorker
{
    class ProDocumentWorker: DocumentWorker
    {       

        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.Write("Документ сохранен в старом формате, ");
            Console.WriteLine("сохранение в других форматах доступно в версии эксперт");
        }
    }
}
