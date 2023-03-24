using Delegates.Services;
using System;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = new Employee[]
            {
                new Employee {Id=1,Name="Mahmoud A",Gender="Male",totalSales =9000m},
                new Employee {Id=2,Name="Ahmed B",Gender="Male",totalSales =9500m},
                new Employee {Id=3,Name="Esraa C",Gender="Female",totalSales =7000m},
                new Employee {Id=4,Name="Ramadan D",Gender="Male",totalSales =8000m},
                new Employee {Id=6,Name="Ali E",Gender="Male",totalSales =12000m},
                new Employee {Id=7,Name="Moustafa F",Gender="Male",totalSales =7000m},
                new Employee {Id=5,Name="Ayman G",Gender="Male",totalSales =4500m},
                new Employee {Id=8,Name="Ashraqt F",Gender="Female",totalSales =6000m},
            };
            var report = new Report();

            report.processEmployee(emps, "Employees With 6000 Plus Sales and Smalles Than 9000", IsGreaterThan6000AndSmallerThan9000);

            report.processEmployee(emps, "Employees With 5000 Plus Sales ", IsGreaterThanOrEqual5000);
            //Another Way
            report.processEmployee(emps, "Employees With 5000 Plus Sales ", delegate (Employee e) { return e.totalSales > 5000m; });
            //Another Way With Lambda Expression
            report.processEmployee(emps, "Employees With 5000 Plus Sales ", (Employee e) => e.totalSales > 5000m);
            //Another Way (احنا بعتنا الكلاس بتاع هناك في الكلاس فا ممكن نشيله خالص من هنا employee  )
            report.processEmployee(emps, "Employees With 5000 Plus Sales ", e => e.totalSales > 5000m);



            report.processEmployee(emps, "Employees Less Than 5000", IsLessThan5000);




        }
        private static void Stock_onPriceChanged(Stock stock, decimal oldPrice)
        {
            if (stock.Price > oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (oldPrice > stock.Price)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;

            }
            Console.WriteLine($"{stock.Name} : {stock.Price}");
        }
        static bool IsGreaterThanOrEqual5000(Employee e) => e.totalSales > 6000m;
        static bool IsGreaterThan6000AndSmallerThan9000(Employee e) => e.totalSales > 6000m && e.totalSales < 9000;
        static bool IsLessThan5000(Employee e) => e.totalSales < 5000m;

    }
}
