using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Birthday
{
    struct Birth
    {
        public DateTime Birthday { get; set; }
        public int DaysToBirthday
        {
            get
            {
                return GetDaysToBirthday();
            }
        }

        public Birth(DateTime birthday)
        {
            this.Birthday = birthday;
        }
        private int GetDaysToBirthday()
        {
            DateTime currentDate = DateTime.Now.Date;
            DateTime birthDate = new DateTime(currentDate.Year, Birthday.Month, Birthday.Day);

            return birthDate.DayOfYear >= currentDate.DayOfYear ?
                birthDate.DayOfYear - currentDate.DayOfYear :
                (currentDate.AddYears(1) - currentDate).Days - (birthDate.DayOfYear - currentDate.DayOfYear);
        }
    }
}
