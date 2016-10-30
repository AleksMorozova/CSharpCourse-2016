using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_3_Book
{
    class Book
    {
        public class Title
        {
            public string titleField;
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(titleField);
                Console.ResetColor();
            }
        }
        public class Author
        {
            public string authorField;
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(authorField);
                Console.ResetColor();
            }
        }
        public class Content
        {
            public string contentField;
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(contentField);
                Console.ResetColor();
            }
        }
        public Title TitleProperty { set; get; }
        public Author AuthorProperty { set; get; }
        public Content ContentProperty { set; get; }
        public Book(Title title, Author author, Content content)
        {
            this.TitleProperty = title;
            this.AuthorProperty = author;
            this.ContentProperty = content;
        }
        public void Show()
        {
            this.TitleProperty.Show();
            this.AuthorProperty.Show();
            this.ContentProperty.Show();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book.Title titleExz = new Book.Title();
            titleExz.titleField = "To Kill a Mockingbird";
            Book.Author authorExz = new Book.Author();
            authorExz.authorField = "Harper Lee";
            Book.Content contentExz = new Book.Content();
            contentExz.contentField = "Novel";

            Book bookFirst = new Book(titleExz, authorExz, contentExz);
            bookFirst.Show();
            
            Console.ReadKey();
        }
    }
}
