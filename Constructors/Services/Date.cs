using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors.Services
{
    internal class Date
    {
        private static readonly int[] DaysToMonth365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] DaysToMonth366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private readonly int day;
        private readonly int month;
        private readonly int year;
        public Date(int dd, int mm, int yyyy)
        {
            var isYearLeap = yyyy % 4 == 0 && (yyyy % 100 != 0 || yyyy % 400 == 0);

            if (yyyy >= 1 && yyyy <= 9999 && mm >= 1 && mm <= 12)
            {
                int[] DaysArray = isYearLeap ? DaysToMonth366 : DaysToMonth365;
                var monthDays = DaysArray[mm];
                if (dd <= monthDays)
                {
                    day = dd;
                    month = mm;
                    year = yyyy;
                }
                else
                {   //Reset Values
                    day = 01;
                    month = 01;
                    year = 01;
                }
            }
            else
            {
                day = 01;
                month = 01;
                year = 01;
            }

        }


        public Date(int yyyy) : this(00, 00, yyyy)
        {
            //هينفذ نفس  لوجيك الكونستراكتور اللي فوق مع اختلاف ان هنا ببعت بارم واحد بس
        }

        public void setValue(int dd, int mm, int yyyy)
        {
            //day = dd;
            //month = mm;
            //year = yyyy;
        }

        public string GetDate() => $"{day.ToString().PadLeft(2, '0')} /{month.ToString().PadLeft(2, '0')} /{year.ToString().PadLeft(4, '0')}";


    }
}
