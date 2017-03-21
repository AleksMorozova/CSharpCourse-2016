using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_Task6_
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours=100;

            Console.WriteLine("{0} worked {1} hours and {2} a bonus", Enum.GetName(typeof(Post), Post.Manager), hours, Accauntant.AskForBonus(Post.Manager, hours) ? "have" : "doesn't have");
            Console.ReadKey();
        }
    }
}
