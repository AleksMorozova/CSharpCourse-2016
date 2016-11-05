using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Accauntant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} worked {1} hours and {2} a bonus", 
                Enum.GetName(typeof(Post), Post.Architector), 
                120, 
                Accauntant.AskForBonus(Post.Architector, 120)? "have" : "doesn't have");
            Console.ReadKey();
        }
    }
}
