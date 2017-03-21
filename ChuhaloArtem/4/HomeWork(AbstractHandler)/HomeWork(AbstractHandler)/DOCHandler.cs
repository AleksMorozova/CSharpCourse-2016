using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_AbstractHandler_
{
    class DOCHandler: AbstractHandler
    {        
        public override void Create()
        {
            Console.WriteLine("Создан DOC документ.");
        }
        public override void Open()
        {
            Console.WriteLine("Открыт DOC документ.");
        }
        public override void Change()
        {
            Console.WriteLine("Изменен DOC документ.");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранен DOC документ.");
        }
    }
}
