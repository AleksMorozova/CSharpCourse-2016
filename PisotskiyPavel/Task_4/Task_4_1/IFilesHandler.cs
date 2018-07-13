using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_1
{
    interface IFilesHandler
    {
        void Register(string extension, AbstractHandler handler);
        AbstractHandler GetHandler(string extension);
    }
}
