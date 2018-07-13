using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_3
{
    class Book
    {
        public Author Author { get; set; }
        public Title Title { get; set; }
        public Content Content { get; set; }

        public void Show()
        {
            Author.Show();
            Title.Show();
            Content.Show();
        }

    }
}
