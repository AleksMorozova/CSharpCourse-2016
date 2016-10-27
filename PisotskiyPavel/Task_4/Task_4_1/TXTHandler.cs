using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_1
{
    class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("txt-файл - изменён");
        }

        public override void Create()
        {
            Console.WriteLine("txt-файл - создан");
        }

        public override void Open()
        {
            Console.WriteLine("txt-файл - открыт");
        }

        public override void Save()
        {
            Console.WriteLine("txt-файл - сохранён");
        }
    }
}
