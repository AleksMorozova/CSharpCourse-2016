using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5FillingForm
{
    class User
    {
        string login;
        string firstName;
        string secondName;
        int age;
        readonly DateTime dateOfFilling;

        public User(string login, string firstName, string secondName, int age)
        {
            this.login = login;
            this.firstName = firstName;
            this.secondName = secondName;
            this.age = age;
            dateOfFilling = DateTime.Now;
        }

        public void ShowUserInformation()
        {
            Console.WriteLine("Information about user: ");
            Console.WriteLine("login: {0}\nfirst name: {1}\nsecond name: {2}\nage: {3}\ndate of filling a form: {4}",
                login, firstName, secondName, age, dateOfFilling);
        }
    }
}
