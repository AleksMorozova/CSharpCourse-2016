using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AbstractHandler
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine(".txt document has opened");
        }
        public override void Create()
        {
            Console.WriteLine(".txt document has created");
        }
        public override void Change()
        {
            Console.WriteLine(".txt document has changed");
        }
        public override void Save()
        {
            Console.WriteLine(".txt document has saved");
        }
    }
}
