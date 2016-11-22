using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions_1_AbstractHandler
{
    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }
    class XMLHandler: AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XMLHandler.Open");
        }
        public override void Create()
        {
            Console.WriteLine("XMLHandler.Create");
        }
        public override void Change()
        {
            Console.WriteLine("XMLHandler.Change");
        }
        public override void Save()
        {
            Console.WriteLine("XMLHandler.Save");
        }
    }
    class TXTHandler: AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXTHandlerOpen");
        }
        public override void Create()
        {
            Console.WriteLine("TXTHandler.Create");
        }
        public override void Change()
        {
            Console.WriteLine("TXTHandler.Change");
        }
        public override void Save()
        {
            Console.WriteLine("TXTHandler.Save");
        }
    }
    class DOCHandle: AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOCHandle.Open");
        }
        public override void Create()
        {
            Console.WriteLine("DOCHandle.Create");
        }
        public override void Change()
        {
            Console.WriteLine("DOCHandle.Change");
        }
        public override void Save()
        {
            Console.WriteLine("DOCHandle.Save");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler docum = null;

            Console.WriteLine("xml || txt || doc");
            string str = Console.ReadLine();

            if(str == "xml")
            {
                docum = new XMLHandler();
            }
            else if( str == "txt")
            {
                docum = new TXTHandler();
            }
            else 
            {
                docum = new DOCHandle();
            }

            docum.Open();
            docum.Create();
            docum.Change();
            docum.Save();

            Console.ReadKey();
        }
    }
}
