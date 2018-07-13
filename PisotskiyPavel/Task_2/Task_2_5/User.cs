using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_5
{
    class User
    {
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public DateTime RegistrationDate { get; protected set; }

        public User(string login, string firstName, string secondName, int age)
        {
            Login = login;
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
            RegistrationDate = DateTime.UtcNow;
        }
    }
}
