using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_Season
{
    class Season : ISeason
    {
        public string GetSeason(Month month)
        {
            string result;
            switch (month)
            {
                case Month.December:
                case Month.Jenuary:
                case Month.February:
                    result = "Winter";
                    break;
                case Month.March:
                case Month.April:
                case Month.May:
                    result = "Spring";
                    break;
                case Month.June:
                case Month.July:
                case Month.August:
                    result = "Summer";
                    break;
                case Month.September:
                case Month.October:
                case Month.November:
                    result = "Autumn";
                    break;
                default:
                    result = "This month doesn't exist in our planet";
                    break;
            }
            return result;
        }
    }
}
