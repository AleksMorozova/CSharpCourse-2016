using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_DocumentWorker
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("The document has edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("The document has saved in old format, saving in another formats accessed in Expert version");
        }
    }
}
