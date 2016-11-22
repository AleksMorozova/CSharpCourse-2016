using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_DocumentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the product key, please: ");
            IDocumentWorker documentWorker = License.GetLicense(Console.ReadLine());
            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();
            Console.ReadKey();
        }
    }
}
