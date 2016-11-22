using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_6_Enum
{
    public enum Post
    {
        ManagingDirector = 160  ,
        OfficeManager = 155,
        ITDirector = 170 ,
        LANAdministrator = 170 ,
        BusinessAnalyst = 180,
        SoftwareDeveloper = 185,
        DatabaseDeveloper = 182,

    }
    class Accountant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            return (hours >= (int)worker); 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Accountant acc = new Accountant();
            Console.Write("Enter the number of hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            foreach (Post item in Enum.GetValues(typeof(Post)))
            {
                Console.WriteLine(item + " \t"+ acc.AskForBonus(item, hours));
            }
            Console.ReadKey();
        }
    }
}
