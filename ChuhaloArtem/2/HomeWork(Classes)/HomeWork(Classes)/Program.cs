using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Classes_
{
    class Program
    {
        static void Main(string[] args)
        {
            string y;
            Address adr = new Address();
            Rectangle rec = new Rectangle();
            Book book = new Book();
            Figure figure = new Figure(new Point(4, 6, "-angel"));
            User user = new User("qwe123","Artem","Chuhalo",20);
            Converter conv = new Converter(5,10,10);
            Employee employee = new Employee("Artem", "Chuhalo");
            Invoice invoice = new Invoice(111111, "Artem Chuhalo", "OAO AAA");
            
            do
            {
                Console.Write("Select activity (address, rectangle, book, figure,\nuser, convert, employee, invoice): ");
                string str = Console.ReadLine();

                switch (str)
                {                    
                    case "address":
                        do
                        {
                            adr.PrintAddress();
                            Console.Write("\nStart address again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                    case "rectangle":
                        do
                        {
                            Console.Write("\nEnter first side of your rectangle: ");
                            rec.Set_Side1 = int.Parse(Console.ReadLine());
                            Console.Write("\nEnter second side of your rectangle: ");                            
                            rec.Set_Side2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Area: {0}", rec.Area);
                            Console.WriteLine("Perimetr: {0}", rec.Perimetr);
                            Console.Write("\nStart rectangle again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                    case "book":
                        do
                        {
                            Console.Write("\n Add author: ");
                            book.author = new Author(Console.ReadLine());
                            Console.Write("\n Add title: ");
                            book.title = new Title(Console.ReadLine());
                            Console.Write("\n Add content: ");
                            book.content = new Content(Console.ReadLine());
                            book.Show();
                            Console.Write("\nStart book again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                    case "figure":
                        do
                        {                            
                            Console.Write("Name: {0}\nPerimetr: {1}", figure.Name, figure.Perimetr);
                            Console.Write("\nStart figure again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                    case "user":
                        do
                        {
                            user.Print();
                            Console.Write("\nStart again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                    case "convert":
                        do
                        {                            
                            conv.Print();
                            Console.Write("\nStart convert again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                  case "employee":
                        do
                        {
                            employee.GetStage = 2;
                            employee.Salary();
                            Console.Write("\nStart  again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;                  
                    case "invoice":
                        do
                        {
                            invoice.Article = "Sky boarding";
                            invoice.Price = 500;
                            invoice.Quantity = 3;
                            invoice.Cost();
                            Console.Write("\nStart again? y/n: ");
                            y = Console.ReadLine();
                        } while (y == "y");
                        break;

                    default:
                        Console.WriteLine("\nInvalid selection. Please select proposed item");
                        break;
                }
                Console.Write("\nStart all again? y/n: ");
                y = Console.ReadLine();
            } while (y == "y");
        }
    }
}
