using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AbstractHandler
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine(".doc document has opened");
        }
        public override void Create()
        {
            Console.WriteLine(".doc document has created");
        }
        public override void Change()
        {
            Console.WriteLine(".doc document has changed");
        }
        public override void Save()
        {
            Console.WriteLine(".doc document has saved");
        }
    }
}
