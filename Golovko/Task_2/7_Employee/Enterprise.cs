using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Employee
{
    class Enterprise
    {
        public string Title { get; private set; }
        public List<Employee> Employees { get; set; }
        public static List<Tax> Taxes { get; set; }
        public static double Tax
        {
            get { return GetSumTax(); }
        }
        public Enterprise(string title)
        {
            this.Title = title;
            Employees = new List<Employee>();
            Taxes = new List<Tax>();
        }
        private static double GetSumTax()
        {
            return Taxes.Sum(tax => tax.TaxValue);
        }
        public void PrintEmployeesInfo()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine("Name: {0}\nSurname: {1}\nPosition: {2}\nSalary: {3}\nTax: {4}", 
                    employee.Name, employee.Surname, employee.Position.Name, employee.Salary, employee.TaxPaid);
            }
        }
    }
}
