using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_Циклы_
{
    class Password
    {
        public void Show()
        {
            string pass = "root";
            string step;

            do
            {
                Console.WriteLine("\nВведите пароль");
                step = Console.ReadLine();
                if (step != pass)
                    Console.WriteLine("Неверный пароль.");
            }while(step!=pass);
            Console.WriteLine("Сделайте вид, что вы рады, получилось.");
        }
    }
}
