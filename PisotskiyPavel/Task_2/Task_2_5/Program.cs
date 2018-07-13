using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("PisotskiyPavel", "Pavel", "Pisotskiy", 22);

            Console.WriteLine("Логин: {0}", user.Login);
            Console.WriteLine("Имя: {0}", user.FirstName);
            Console.WriteLine("Фамилия: {0}", user.SecondName);
            Console.WriteLine("Возраст: {0}", user.Age);
            Console.WriteLine("Дата заполнения анкеты: {0}", user.RegistrationDate.ToLocalTime());

            Console.ReadLine();
        }
    }
}
