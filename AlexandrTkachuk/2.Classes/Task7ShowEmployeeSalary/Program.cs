using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7ShowEmployeeSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Alexandr", "Tkachuk");
            EmployeeInfo employeeInfo = new EmployeeInfo(Position.chief, 10);
            employee.ShowSalaryAndTax(employeeInfo);
        }
    }
}
