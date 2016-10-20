using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Enterprise enterprise = new Enterprise("ISD");
            Enterprise.Taxes.Add(new Tax("Social ensuarence", 5));
            Enterprise.Taxes.Add(new Tax("Provident found", 15));
            Enterprise.Taxes.Add(new Tax("Other paids", 10));
            Employee developer = new Employee("Jhon", "Jhames");
            Employee admin = new Employee("Macy", "Luis");
            Employee manager = new Employee("Kate", "Willis");
            developer.Position = new Position(".NET Developer", 2500, 200);
            developer.Experience = 8;
            admin.Position = new Position("DevOps", 2000, 150);
            admin.Experience = 5;
            manager.Position = new Position("Project manager", 2800, 220);
            manager.Experience = 10;
            enterprise.Employees.Add(developer);
            enterprise.Employees.Add(admin);
            enterprise.Employees.Add(manager);
            enterprise.PrintEmployeesInfo();
            Console.ReadKey();
        }
    }
}
