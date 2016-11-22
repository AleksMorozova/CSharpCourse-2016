using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Console
{
    sealed class FIO : IFIO
    {
        private readonly string surname;
        private readonly string name;
        private readonly string patronimic;
        public FIO(string surname, string name, string patronimic)
        {
            this.surname = surname;
            this.name = name;
            this.patronimic = patronimic;
        }
        public void Introduce()
        {
            string fio = surname + " " + name + " " + patronimic;
            int length = fio.Length;
            Console.WriteLine("+{0}+",  new string('-', length));
            Console.WriteLine("|{0}|", fio);
            Console.WriteLine("+{0}+", new string('-', length));
        }
     }
}
