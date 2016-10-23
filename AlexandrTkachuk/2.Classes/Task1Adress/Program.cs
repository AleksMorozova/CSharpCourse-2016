using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Adress
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress(49000, "Ukraine", "Dnipro", "Geroev", 12, 45);
            adress.ShowAdress();
        }
    }
}
