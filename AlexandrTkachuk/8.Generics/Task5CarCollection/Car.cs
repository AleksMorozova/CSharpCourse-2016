using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5CarCollection
{
    class Car
    {
        string name;
        int yearOfCreating;

        public string Name
        {
            get { return name; }
        }
        
        public int YearOfCreating
        {
            get { return yearOfCreating; }
        }

        public Car(string name, int yearOfCreating)
        {
            this.name = name;
            this.yearOfCreating = yearOfCreating;       
        }

    }
}
