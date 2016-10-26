using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_3
{
    class Car : Vehicle
    {
        public Car(double price, double speed, int yearOfIssue) 
            : base(price, speed, yearOfIssue)
        {
        }
    }
}
