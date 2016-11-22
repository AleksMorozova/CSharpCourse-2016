using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_DocumentWorker
{
    class DocumentWorker : IDocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document has opened");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("The document edition acceessed in Pro version");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("The document saving accessed in Pro version");
        }
    }
}
