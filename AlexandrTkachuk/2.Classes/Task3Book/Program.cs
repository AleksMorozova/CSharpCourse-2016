using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("The Old Man And The Sea", "Ernest Hemingway", 
                "He was an old man who fished alone in a skiff in the Gulf Stream");
            book.ShowBookInfo();
        }
    }
}
