using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AbstractHandler
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine(".xml document has opened");
        }
        public override void Create()
        {
            Console.WriteLine(".xml document has created");
        }
        public override void Change()
        {
            Console.WriteLine(".xml document has changed");
        }
        public override void Save()
        {
            Console.WriteLine(".xml document has saved");
        }
    }
}
