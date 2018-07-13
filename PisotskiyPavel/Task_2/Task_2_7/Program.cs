using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> employees = GetEmployees();

            foreach (var employee in employees)
            {
                Console.WriteLine("{0} {1}:", employee.FirstName, employee.SecondName);
                Console.WriteLine("\tДолжность: {0}",employee.Position.PositionName);
                Console.WriteLine("\tСтаж: {0}", employee.Experience);
                Console.WriteLine("\tЗар. плата: {0}", employee.GetSalary());
                Console.WriteLine("\tНалоговый сбор: {0}", employee.GetTaxLevy());
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        static IEnumerable<Employee> GetEmployees()
        {
            EmployeePosition director = new EmployeePosition()
            {
                FixedRate = 10000,
                PositionName = "Директор",
                Surcharge = 500
            };

            EmployeePosition manager = new EmployeePosition()
            {
                FixedRate = 5000,
                PositionName = "Менеджер",
                Surcharge = 250
            };

            EmployeePosition salesman = new EmployeePosition()
            {
                FixedRate = 2000,
                PositionName = "Продавец",
                Surcharge = 100
            };


            return new Employee[]
            {
                new Employee("Владимир", "Владимиров")
                {
                    Position = director,
                    Experience = 15
                },
                new Employee("Екатерина", "Семенова")
                {
                    Position = manager,
                    Experience = 10
                },
                new Employee("Светлана", "Петрова")
                {
                    Position = salesman,
                    Experience = 5
                }
            };
        }
    }
}
