using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Book
{
    class Title: IShow
    {
        string title;

        public Title(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Title: " + title);
        }
    }
}
