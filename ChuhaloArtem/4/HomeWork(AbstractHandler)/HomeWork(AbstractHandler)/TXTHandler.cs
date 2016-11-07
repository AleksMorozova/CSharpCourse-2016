using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_AbstractHandler_
{
    class TXTHandler: AbstractHandler
    {        
        public override void Create()
        {
            Console.WriteLine("Создан TXT документ.");
        }
        public override void Open()
        {
            Console.WriteLine("Открыт TXT документ.");
        }
        public override void Change()
        {
            Console.WriteLine("Изменен TXT документ.");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранен TXT документ.");
        }
    }
}
