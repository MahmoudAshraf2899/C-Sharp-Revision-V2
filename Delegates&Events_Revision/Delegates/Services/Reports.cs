using System.Collections.Generic;

namespace Delegates.Services
{
    public class Reports
    {

        //Delegate Object that points to method Ai changed at run time
        //The Difference between delegate and method that method has body but delegate is not
        //Delegate tis reference type
        public delegate bool salesDelegate(Employee e);

        public void processEmployees(Employee[] employees, string title, salesDelegate salesCondition)
        {
            Console.WriteLine(title);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var item in employees)
            {
                if (salesCondition(item))
                {
                    Console.WriteLine($"{item.Id} | {item.Name} | {item.Gender} | {item.totalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }


        #region Before Creating Delegate
        //public void ProcessEmployeeWithBigThan1000(Employee[] employees)
        //{
        //    Console.WriteLine("Employees With Sales More Than 1000");
        //    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        //    foreach (var item in employees)
        //    {
        //        if (item.totalSales >= 1000m)
        //        {
        //            Console.WriteLine($"{item.Id} | {item.Name} | {item.Gender} | {item.totalSales}");
        //        }
        //    }
        //    Console.WriteLine("\n\n");

        //}

        //// less than 800 and less than 1500
        //public void ProcessEmployeeWithTotalSalesLessThan1500AndMoreThan800(Employee[] employees)
        //{
        //    Console.WriteLine("Employees With Sales More than 800 and less Than 1500");
        //    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        //    foreach (var item in employees)
        //    {
        //        if (item.totalSales >= 800m && item.totalSales <= 1500)
        //        {
        //            Console.WriteLine($"{item.Id} | {item.Name} | {item.Gender} | {item.totalSales}");
        //        }
        //    }
        //    Console.WriteLine("\n\n");

        //}

        ////List Of Employees That There total sales less than 3000
        //public void ProcessEmployeeWithTotalSalesLessThan3000(Employee[] employees)
        //{
        //    Console.WriteLine("Employees With Sales less than 3000");
        //    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        //    foreach (var item in employees)
        //    {
        //        if (item.totalSales < 3000)
        //        {
        //            Console.WriteLine($"{item.Id} | {item.Name} | {item.Gender} | {item.totalSales}");
        //        }
        //    }
        //    Console.WriteLine("\n\n");

        //} 
        #endregion
    }
}
