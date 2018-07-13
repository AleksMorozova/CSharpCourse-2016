using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post = Post.Director;
            int hours = 170;
            Console.WriteLine("{0} отработал {1} часов",  post, hours);
            Accountant acc = new Accountant();
            Console.Write("Положена ли премия? {0}", acc.AskForBonus(post, hours) ? "Да" : "Нет");

            Console.ReadLine();
        }
    }
}
