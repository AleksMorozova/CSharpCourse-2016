using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_DocumentWorker
{
    interface IDocumentWorker
    {
        void OpenDocument();
        void EditDocument();
        void SaveDocument();
    }
}
