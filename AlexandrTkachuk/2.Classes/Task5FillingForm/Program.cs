using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5FillingForm
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Alex", "Alexandr", "Tkachuk", 20);
            user1.ShowUserInformation();
        }
    }
}
