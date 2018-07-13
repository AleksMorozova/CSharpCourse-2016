using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IFilesHandler filesHandler = GetFilesHandler();
            Console.Write("Введите формат файла (например .doc): ");
            string extension = Console.ReadLine();

            try
            {
                AbstractHandler handler = filesHandler.GetHandler(extension);
                handler.Create();
                handler.Open();
                handler.Change();
                handler.Save();
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Данный формат не поддерживается!!!");
            }
            

            Console.ReadLine();
        }

        static IFilesHandler GetFilesHandler()
        {
            IFilesHandler filesHandler = new FilesHandler();

            filesHandler.Register(".txt", new TXTHandler());
            filesHandler.Register(".xml", new XMLHandler());
            filesHandler.Register(".doc", new DOCHandler());

            return filesHandler;
        }
    }
}
