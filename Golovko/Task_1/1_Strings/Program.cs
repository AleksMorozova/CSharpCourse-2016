using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IFIO fio = new FIO("Golovko", "Gregory", "Nickolaevich");
            fio.Introduce();
            Console.ReadKey();
        }
    }
}
