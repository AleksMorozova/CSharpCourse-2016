using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                var artem1 = new Person() { FirstName = "Artem", SecondName = "Chuhalo" };
                var artem2 = new Person() { FirstName = "Artem", SecondName = "Chuhalo" };
                var artem3 = new Person() { FirstName = "Artem", SecondName = "Chuhalo" };
                context.People.Add(artem1);
                context.People.Add(artem2);
                context.People.Add(artem3);

                context.SaveChanges();

                foreach (var person in context.People)
                {
                    Console.WriteLine("{0} ye v {1}", person.FirstName, person.SecondName);
                }
            }
        }
    }
}
