using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_DayOfWeek
{
    class Day : IDay
    {
        public string GetName(DayName day)
        {
            if ((byte)day < 1 || (byte)day > 7 ) return "This day name doesn't exist";
            return day.ToString();
        }
    }
}
