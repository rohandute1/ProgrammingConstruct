using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    internal class WeekdayCalculator
    {
        public string CalculateWeekdayName(int weekdayNumber)
        {
            string weekdayName;

            switch (weekdayNumber)
            {
                case 1:
                    weekdayName = "Sunday";
                    break;
                case 2:
                    weekdayName = "Monday";
                    break;
                case 3:
                    weekdayName = "Tuesday";
                    break;
                case 4:
                    weekdayName = "Wednesday";
                    break;
                case 5:
                    weekdayName = "Thursday";
                    break;
                case 6:
                    weekdayName = "Friday";
                    break;
                case 7:
                    weekdayName = "Saturday";
                    break;
                default:
                    weekdayName = "Invalid weekday number";
                    break;
            }

            return weekdayName;
        }
    }
}
