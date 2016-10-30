using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_7_Employee
{
    class Employee
    {
        private string name;
        private string surname;
        private string position;
        private double experience;
        private double salary;
        private double tax;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public double Experience
        {
            get { return experience; }
            set { experience = value; }
        }
        public double Salary
        {
            get { return salary; }
        }
        public double Tax
        {
            get { return tax; }
        }

        public Employee(string n, string s)
        {
            name = n;
            surname = s;
            position = "Manager";
            experience = 3.3;
            SalaryCalculator();
            TaxCalculator();
        }
        public void SalaryCalculator()
        {
            salary = 112.3 * experience; //also depends on position
        }
        public void TaxCalculator()
        {
            tax = 2321.2 * salary; //depends on 
        }
        public void Show()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Surname: {0}", surname);
            Console.WriteLine("Position: {0}", position);
            Console.WriteLine("Salary: {0}", salary);
            Console.WriteLine("Tax: {0}", tax);
            Console.WriteLine("");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Artem", "Babkin");
            employee1.Show();
            Console.ReadKey();
        }
    }
}
