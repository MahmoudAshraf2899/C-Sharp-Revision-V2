using System;

namespace Extension_Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);//OutPut : yyyy-MM-dd hh:mm:ss
            Console.WriteLine($"Date Time Now{ dt}");
            //dt = new DateTime(2021, 03, 01, 11, 30, 00);
            //Console.WriteLine($"Date Time initialized{ dt }");

            #region DateTime Offset
            ////Return Current date and the gap between Current and UTC
            //DateTimeOffset dts = DateTimeOffset.Now;
            //Console.WriteLine($"Date Time Offset Now { dts}");


            ////Return Time At UTC (التوقيت العالمي)
            //DateTimeOffset dtsNow = DateTimeOffset.UtcNow;
            //Console.WriteLine($"Date Time Offset UTC Now { dtsNow}"); 
            #endregion
            #region Add Methods With Date Time
            //TimeSpan ts = new TimeSpan(02, 15, 00);
            //var addSpanDate = dt.Add(ts);
            //Console.WriteLine($"Date After Using Add Method : {addSpanDate}");

            //DateTime dt2 = DateTime.Now;
            //var addTwoDaysDate = dt2.AddDays(20);
            //Console.WriteLine($"Date After Add Two Days : {addTwoDaysDate}"); 
            #endregion

            #region Work with Vacation Days
            var isWeekEnd =  DateTimeHelper.isWeekEnd(dt);
            if (isWeekEnd)
                Console.WriteLine("Vacation Day");
            else
                Console.WriteLine("Work Day");
            //Get Days That not vacation
            var isWeekDay = DateTimeHelper.isWeekDay(dt);
            if(isWeekDay)
                Console.WriteLine("OPEN");
            else
                Console.WriteLine("Closed");
            
            #endregion

            Console.ReadKey();
        }

    }
}
