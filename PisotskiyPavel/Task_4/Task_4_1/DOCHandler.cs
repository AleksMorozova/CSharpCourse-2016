using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_1
{
    class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("doc-файл - изменён");
        }

        public override void Create()
        {
            Console.WriteLine("doc-файл - создан");
        }

        public override void Open()
        {
            Console.WriteLine("doc-файл - открыт");
        }

        public override void Save()
        {
            Console.WriteLine("doc-файл - сохранён");
        }
    }
}
