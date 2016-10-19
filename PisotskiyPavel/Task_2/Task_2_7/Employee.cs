using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_7
{
    class Employee
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Experience { get; set; }
        public EmployeePosition Position { get; set; }

        private double tax = 0.18;

        public Employee(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }

        public double GetSalary()
        {
            return Position.FixedRate + Experience * Position.Surcharge;
        }

        public double GetTaxLevy()
        {
            return GetSalary() * tax;
        }
        
    }
}
