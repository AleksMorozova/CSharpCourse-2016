using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FileSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            File file = new File(File.Search("Licence.txt", @"D:\AFF").FirstOrDefault());
            file.Show();
            file.Compress();
            Console.WriteLine("File size: {0} bytes\nCompressed file size: {1} bytes", file.Size, file.CompressedSize);
            Console.ReadKey();
        }
    }
}
