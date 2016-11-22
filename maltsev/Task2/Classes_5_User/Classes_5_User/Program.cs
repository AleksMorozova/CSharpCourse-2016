using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_5_User
{
    class User
    {
        private string name;
        private string surname;
        private string login;
        private int age;
        private string date;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Surname
        {
            set { surname = value; }
            get { return surname; }
        }
        public string Login
        {
            set { login = value; }
            get { return login; }
        }
        public int Age 
        {
            set { age = value; }
            get { return age; }
        }
        public string Date
        {
            get { return date; }
        }

        public User(string n, string s, string l, int a, string d )
        {
            this.name = n;
            this.surname = s;
            this.login = l;
            this.age = a;
            this.date = d;
        }
        public void Show()
        {
            Console.WriteLine("Login: {0}", login);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Surname: {0}", surname);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Date: {0}", date);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Nikita", "Maltsev", "MalN123", 19, "08.10.2016");
            user1.Show();
            Console.ReadKey();
        }
    }
}
