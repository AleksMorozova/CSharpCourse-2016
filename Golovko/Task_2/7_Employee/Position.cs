using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Employee
{
    class Position
    {
        public string Name { get; private set; }
        public double Salary { get; private set; }
        public double Surcharge { get; private set; }
        public Position(string name, double salary, double surcharge)
        {
            this.Name = name;
            this.Salary = salary;
            this.Surcharge = surcharge;
        }
    }
}
