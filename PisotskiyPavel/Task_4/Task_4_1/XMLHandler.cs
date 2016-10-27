using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_1
{
    class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("xml-файл - изменён");
        }

        public override void Create()
        {
            Console.WriteLine("xml-файл - создан");
        }

        public override void Open()
        {
            Console.WriteLine("xml-файл - открыт");
        }

        public override void Save()
        {
            Console.WriteLine("xml-файл - сохранён");
        }
    }
}
