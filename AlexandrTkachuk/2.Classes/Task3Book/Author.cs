using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Book
{
    class Author: IShow
    {
        string authorName;

        public Author(string authorName)
        {
            this.authorName = authorName;
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Author: " + authorName);
        }
    }
}
