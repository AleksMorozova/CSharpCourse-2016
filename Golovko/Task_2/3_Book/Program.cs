using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Title = new Title("Shantaram");
            book.Author = new Author("Gregory David Roberts");
            book.Content = new Content("India GOA");
            book.Show();
            Console.ReadKey();
        }
    }
}
