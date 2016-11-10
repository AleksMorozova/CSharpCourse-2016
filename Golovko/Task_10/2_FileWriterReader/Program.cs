using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_FileWriterReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This is test data text\nThis is test data text\nThis is test data text\nThis is test data text\nThis is test data text\nThis is test data text\n";
            string path = @"D:\";
            string fileName = "test.data";
            File.Save(path, fileName, text);
            Console.WriteLine(File.Read(path + fileName));
            Console.ReadKey();
        }
    }
}
