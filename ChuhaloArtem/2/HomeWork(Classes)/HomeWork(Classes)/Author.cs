using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Classes_
{
    class Author
    {
        string author;

        public Author(string author)
        {
            this.author = author;
        }
             public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(author);
            Console.ResetColor();
        }
    }
}
