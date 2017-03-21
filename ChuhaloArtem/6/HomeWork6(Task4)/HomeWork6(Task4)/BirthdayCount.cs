using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_Task4_
{
    class BirthdayCount
    {
        public DateTime birthday { get; set; }
        public int BirthCount{get{return GetBirthCount();}}

        public BirthdayCount(DateTime birthday)
        {
            this.birthday = birthday;
        }

        private int GetBirthCount()
        {
            DateTime current = DateTime.Now.Date;
            DateTime birthDate = new DateTime(current.Year, birthday.Month, birthday.Day);

            return birthDate.DayOfYear >= current.DayOfYear ? birthDate.DayOfYear - current.DayOfYear :(current.AddYears(1) - current).Days - (birthDate.DayOfYear - current.DayOfYear);
        }
    }
}
