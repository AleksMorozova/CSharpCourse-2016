using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Classes_
{
    class User
    {
        //Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты). 
        //Поле дата заполнения анкеты должно быть проинициализировано только один раз (при создании экземпляра данного класса) 
        //без возможности его дальнейшего изменения.Реализуйте вывод на экран информации о пользователе.
        string login;
        string name;
        string surname;
        int age;
        private readonly DateTime date;

        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            date = DateTime.Now;
        }
        public void Print()
          {
              Console.WriteLine("Login:{0}\nName: {1}\nSurname: {2}\nAge: {3}\nDate: {4}",login,name,surname,age,date);
          }
    }
}
