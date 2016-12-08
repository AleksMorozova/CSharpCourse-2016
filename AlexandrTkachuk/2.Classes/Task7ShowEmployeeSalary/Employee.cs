using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7ShowEmployeeSalary
{
    class Employee
    {
        string firstName;
        string secondName;
        int salary;
        double amountOfTaxLevy;
        const double taxLevyCoefficient = 0.20;
        const int workExperienceСoefficient = 100;

        public Employee(string firstName, string secondName)
        {
            this.firstName = firstName;
            this.secondName = secondName;
        }

        public void ShowSalaryAndTax(EmployeeInfo employeeInfo)
        {
            CanculateSalary(employeeInfo);
            CanculateAmountOfTaxLevy();
            Console.WriteLine("Информация о сотруднике:");
            Console.WriteLine("First name: {0}\nSecond: {1}", firstName, secondName);
            Console.WriteLine("Position: {0}\nSalary: {1}$", employeeInfo.Position, salary);
            Console.WriteLine("Tax levy: {0}$", amountOfTaxLevy);        
        }

        void CanculateSalary(EmployeeInfo employeeInfo)
        {
            switch (employeeInfo.Position)
            { 
                case Position.guard:
                    salary = 500;
                    break;
                case Position.programmer:
                    salary = 1000;
                    break;
                case Position.chief:
                    salary = 5000;
                    break;
                default:
                    Console.WriteLine("Error");
                    break;          
            }
            salary += employeeInfo.WorkExperience * workExperienceСoefficient;
        }

        void CanculateAmountOfTaxLevy()
        {
            amountOfTaxLevy = salary * taxLevyCoefficient;
        }

    }
}
