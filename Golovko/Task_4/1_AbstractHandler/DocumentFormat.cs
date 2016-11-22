using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AbstractHandler
{
    class DocumentFormat
    {
        public static AbstractHandler GetHandler(string documentFormat)
        {
            AbstractHandler abstractHandler;
            switch (documentFormat)
            {
                case ".xml":
                    abstractHandler = new XMLHandler();
                    break;
                case ".txt":
                    abstractHandler = new TXTHandler();
                    break;
                case ".doc":
                    abstractHandler = new DOCHandler();
                    break;
                default:
                    abstractHandler = null;
                    break;
            }
            return abstractHandler;
        }
    }
}
