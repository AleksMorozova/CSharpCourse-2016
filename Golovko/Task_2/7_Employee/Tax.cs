using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Employee
{
    class Tax
    {
        public string Name { get; private set; }
        public double TaxValue { get; private set; }
        public Tax(string name, double taxValue)
        {
            this.Name = name;
            this.TaxValue = taxValue;
        }
    }
}
