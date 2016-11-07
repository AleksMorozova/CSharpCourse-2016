using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_AbstractHandler_
{
    class XMLHandler: AbstractHandler
    {        
        public override void Create()
        {
            Console.WriteLine("Создан XML документ.");
        }
        public override void Open()
        {
            Console.WriteLine("Открыт XML документ.");
        }
        public override void Change()
        {
            Console.WriteLine("Изменен XML документ.");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранен XML документ.");
        }
    }
}
