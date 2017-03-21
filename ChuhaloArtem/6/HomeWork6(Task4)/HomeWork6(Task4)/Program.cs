using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_Task4_
{
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayCount birth = new BirthdayCount(new DateTime(1996, 02, 10));

            Console.WriteLine(birth.BirthCount);        
            Console.ReadKey();
        }
    }
}
