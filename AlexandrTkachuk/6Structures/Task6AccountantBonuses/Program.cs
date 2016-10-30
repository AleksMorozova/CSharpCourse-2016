using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6AccountantBonuses
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Accountant.AskforBonus(Post.Programmist, 170) == true)
            {
                Console.WriteLine("Take a bonus");
            }
            else 
            {
                Console.WriteLine("No bonuses, work harder");
            }
        }
    }
}
