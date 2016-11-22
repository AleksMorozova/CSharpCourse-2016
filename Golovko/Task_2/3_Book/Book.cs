using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Book
{
    class Book
    {
        public Title Title { get; set; }
        public Author Author { get; set; }
        public Content Content { get; set; }
        public void Show()
        {
            Title.Show();
            Author.Show();
            Content.Show();
        }
    }
}
