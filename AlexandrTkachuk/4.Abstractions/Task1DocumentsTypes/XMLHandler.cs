using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1DocumentsTypes
{
    class XMLHandler: AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("In method Open(). Class XMLXandler");     
        }
        public override void Create()
        {
            Console.WriteLine("In method Create(). Class XMLXandler");
        }
        public override void Change()
        {
            Console.WriteLine("In method Change(). Class XMLXandler");
        }
        public override void Save()
        {
            Console.WriteLine("In method Save(). Class XMLXandler");
        }
    }
}
