using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_User
{
    class User
    {
        private readonly DateTime date;
        public string Login { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public uint Age { get; private set; }
        public User(string login, string name, string surname, uint age)
        {
            this.Login = login;
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            date = DateTime.Now;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Login: {0}\nName: {1}\nSurname: {2}\nAge: {3}\nFilling date: {4}", Login, Name, Surname, Age, date);
        }
    }
}
