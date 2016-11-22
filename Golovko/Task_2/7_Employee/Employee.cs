using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Employee
{
    class Employee
    {
        private readonly string name;
        private readonly string surname;
        public string Name { get { return name; } }
        public string Surname { get { return surname; } }
        public Position Position { get; set; }
        public int Experience { get; set; }
        public double Salary
        {
            get { return GetSalary(); }
        }
        public double TaxPaid
        {
            get { return GetTaxes(); }
        }
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        private double GetSalary()
        {
            return Position.Salary + Experience * Position.Surcharge;
        }
        private double GetTaxes()
        {
            return GetSalary() * Enterprise.Tax / 100;
        }
    }
}
