using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6AccountantBonuses
{
    static class Accountant
    {
        static public bool AskforBonus(Post post, int hours)
        {
            if (hours > (int)post)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
