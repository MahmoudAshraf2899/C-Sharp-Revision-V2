using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Services
{
    internal class Report
    {
        #region Apply Delegate
        public delegate bool totalSalesCondition(Employee employee);


        public void processEmployees(Employee[] emps, string title, totalSalesCondition delegateCondition)
        {
            Console.WriteLine(title);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var item in emps)
            {
                if (delegateCondition(item))//Employee employee
                {
                    Console.WriteLine($"{item.Id} |  {item.Name} | {item.Gender} | {item.totalSales}");
                }
            }
            Console.WriteLine("\n\n");
        } 
        #endregion

        /// <summary>
        /// Employees With Sales Greater Than 60000
        /// </summary>
        public void ProcessEmployeeWith60000PlusSales(Employee[] employees)
        {
            Console.WriteLine("--Employees With +60000 Sales");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var item in employees)
            {
                if (item.totalSales >= 60000)
                {
                    Console.WriteLine($"{item.Id} |  {item.Name} | {item.Gender} | {item.totalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }

        /// <summary>
        /// Employees With Sales Greater Than 30000 and less than 59000
        /// </summary>
        /// <param name="employees"></param>
        public void ProcessEmployeesWithSalesBetween30000And59000(Employee[] employees)
        {
            Console.WriteLine("--Employees With More than 30000 and less than 590000");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var item in employees)
            {
                if (item.totalSales >= 30000 && item.totalSales <= 59000)
                {
                    Console.WriteLine($"{item.Id} |  {item.Name} | {item.Gender} | {item.totalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }

        /// <summary>
        /// Employees With Sales Less Than 30000  
        /// </summary>
        /// </summary>
        /// <param name="employees"></param>
        public void ProcessEmployeesWithLessThan30000(Employee[] employees)
        {
            Console.WriteLine("--Employees With Sales less than 30000");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var item in employees)
            {
                if (item.totalSales < 30000)
                {
                    Console.WriteLine($"{item.Id} |  {item.Name} | {item.Gender} | {item.totalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
