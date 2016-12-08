using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4CounterDaysTillBirthday
{
    class CounterDaysTillBirthday
    {
        DateTime birthdayDate;

        public CounterDaysTillBirthday(int monthNumber, int dayNumber)
        {
            birthdayDate = CreateBirthdayDate(monthNumber, dayNumber);       
        }

        DateTime CreateBirthdayDate(int monthNumber, int dayNumber)
        {
            if (monthNumber < DateTime.Today.Month || (monthNumber == DateTime.Today.Month && dayNumber < DateTime.Today.Day))
            {
                return new DateTime(DateTime.Today.Year + 1, monthNumber, dayNumber);
            }
            else
            {
                return new DateTime(DateTime.Today.Year, monthNumber, dayNumber);
            }
        }


        public int CalculateQuantityDaysTillBirthday()
        {
            return  (birthdayDate - DateTime.Today).Days;
        }
    }
}
