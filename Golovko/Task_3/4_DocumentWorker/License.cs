using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_DocumentWorker
{
    class License
    {
        public static DocumentWorker GetLicense(string key)
        {
            DocumentWorker documentWorker;
            switch (key)
            {
                case "pro":
                    documentWorker = new ProDocumentWorker();
                    break;
                case "exp":
                    documentWorker = new ExpertDocumentWorker();
                    break;
                default:
                    documentWorker = new DocumentWorker();
                    break;
            }
            return documentWorker;
        } 
    }
}
