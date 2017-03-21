using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Classes_
{
    class Employee
    {
        private double nds;
        private string name;
        private string status;
        private double minsalary;
        private string surname;
        private double stage;

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public double GetStage
        {
            get { return stage; }
            set { stage=value; }
        }      

        public void Salary()
        {
            double salary;
            Console.WriteLine("\nSelect status (admin, developer, manager): ");
            status = Console.ReadLine();

            if (status == "admin")
            {
                minsalary = 1000;
                nds = minsalary * 0.1;
            }
            else
            {
                minsalary = 2000;
                nds=minsalary*0.2;
            }

            salary = minsalary = minsalary - nds + 500 * GetStage;
            Console.WriteLine("Name: {0}\nSurname: {1}\nStatus: {2}\nStage: {3}\nSalary: {4}\nNDS: {5}", name, surname, status, GetStage, salary, nds);
        }
    }
}
