using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book()
            {
                Author = new Author("Jeffrey Richter"),
                Title = new Title("CLR via C#"),
                Content = new Content("CLR via C#. Программирование на платформе Microsoft.NET Framework 4.5 на языке C#")
            };
            book.Show();

            Console.ReadLine();
        }
    }
}
