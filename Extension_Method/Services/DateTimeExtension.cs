using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    /// <summary>
    /// This keyword : will let us use Methods Directly From Datetime class 
    /// </summary>
    public static class DateTimeExtension
    {
        public static bool IsWeekEnd(this DateTime value)
        {
            return value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek == DayOfWeek.Sunday;
        }
        public static bool IsWeekDay(this DateTime value)
        {
            return !IsWeekEnd(value);
        }
    }
}
