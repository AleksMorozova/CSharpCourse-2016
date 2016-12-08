using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Book
{
    class Content: IShow
    {
        string text;
        public Content(string text)
        {
            this.text = text;
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Content: " + text);
        }
    }
}
