using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Book
{
    class Book
    {
        Title title;
        Author author;
        Content content;

        public Book(string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
        }

        public void ShowBookInfo()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
