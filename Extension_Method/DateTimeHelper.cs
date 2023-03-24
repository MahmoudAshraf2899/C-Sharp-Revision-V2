using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    internal class DateTimeHelper
    {
        public static bool isWeekEnd(DateTime value)
        {
            return (value.DayOfWeek == DayOfWeek.Friday) || (value.DayOfWeek == DayOfWeek.Saturday) ? true : false;
        }
        /// <summary>
        /// Return Days that not vacation days
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool isWeekDay(DateTime value)
        {
            //Apply Reuseability
            return !isWeekEnd(value);
        }
    }
}
