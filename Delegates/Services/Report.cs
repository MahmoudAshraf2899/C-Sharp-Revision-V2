using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Services
{
    internal class Report
    {
        public delegate bool illegibleSales(Employee e);
        public void processEmployee(Employee[] employees, string title, illegibleSales illegible)
        {
            Console.WriteLine(title);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (Employee employee in employees)
            {
                if (illegible(employee))
                {
                    Console.WriteLine($"Employee Name : {employee.Name} ");
                }
            }
            Console.WriteLine("\n\n");
        }
        public void processEmployeeWith5000PlusSales(Employee[] employees)
        {
            Console.WriteLine("Employees With 5,000 Plus Sales");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (Employee employee in employees)
            {
                if (employee.totalSales > 5000)
                {
                    Console.WriteLine($"Employee Name : {employee.Name} ");
                }
            }
            Console.WriteLine("\n\n");
        }
        public void processEmployeeWith6000PlusSalesAndSmallerThan9000(Employee[] employees)
        {
            Console.WriteLine("Employees With 6,000 Plus Sales and smaller than 9.000");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (Employee employee in employees)
            {
                if (employee.totalSales > 6000 && employee.totalSales < 9000)
                {
                    Console.WriteLine($"Employee Name : {employee.Name} ");
                }
            }
            Console.WriteLine("\n\n");
        }
        public void processEmployeeLessThan5000(Employee[] employees)
        {
            Console.WriteLine("Employees With 5,000");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (Employee employee in employees)
            {
                if (employee.totalSales < 5000)
                {
                    Console.WriteLine($"Employee Name : {employee.Name} ");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
