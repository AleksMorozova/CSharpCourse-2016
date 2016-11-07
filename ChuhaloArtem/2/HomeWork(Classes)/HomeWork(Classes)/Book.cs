using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Classes_
{
    class Book
    {
        public Title title 
        { get; set; }
        public Author author 
        { get; set; }
        public Content content 
        { get; set; }

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }        
    }
}