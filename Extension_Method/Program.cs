using System;
using Extension_Method.Services;

namespace Extension_Method
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region Date Time & Date Time Offset
            DateTime dt = DateTime.Now;
            Console.WriteLine($"DateTime.Now: {dt}");
            dt = new DateTime(2021, 3, 1, 11, 30, 00);
            Console.WriteLine($"DateTime : {dt}");

            DateTimeOffset dts = DateTimeOffset.Now;
            Console.WriteLine($"DateTimeOffset : {dts}"); //الفرق بين التوقيت الحالي والتوقيت العالمي

            //Display UTC DATE 
            dts = DateTimeOffset.UtcNow;
            Console.WriteLine($"UTC Date : {dts}");
            TimeSpan ts = new TimeSpan(12, 00, 00);
            dt.Add(ts);
            Console.WriteLine($"Date After Add Time Span : {dt}");

            #endregion
            #region After Creating Extenstion Method
            //First Way To Call Extension Method
            Console.WriteLine($"Date Time From Extension Method : {dt.IsWeekEnd()}");
            //Second Way To Call Extension Method
            Console.WriteLine($"Date Time From Extension Method : {DateTimeExtension.IsWeekEnd(dt)}");
            #endregion

            Pizza pizza = new Pizza();
            pizza = PizzaExtensions.AddDough(PizzaExtensions.AddSauce(PizzaExtensions.AddCheese(null, true)),"Italian");
            pizza.AddDough("Italian").AddSauce().AddCheese(true); //Syntax Using Extension Method

            Console.ReadKey();
        }

    }
}
