using Delegates.Services;
using System;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Add Some Employees
            //var emps = new Employee[]
            //   {
            //    new Employee {Id=1,Name="Mahmoud A",Gender="Male",totalSales =90000m},
            //    new Employee {Id=2,Name="Ahmed B",Gender="Male",totalSales =45000m},
            //    new Employee {Id=3,Name="Esraa C",Gender="Female",totalSales =7000m},
            //    new Employee {Id=4,Name="Ramadan D",Gender="Male",totalSales =3200m},
            //    new Employee {Id=6,Name="Ali E",Gender="Male",totalSales =63000m},
            //    new Employee {Id=7,Name="Moustafa F",Gender="Male",totalSales =57000m},
            //    new Employee {Id=5,Name="Ayman G",Gender="Male",totalSales =22000m},
            //    new Employee {Id=8,Name="Ashraqt F",Gender="Female",totalSales =6000m},
            //   };
            #endregion

            //var report = new Report();
            //report.ProcessEmployeeWith60000PlusSales(emps);
            //report.ProcessEmployeesWithSalesBetween30000And59000(emps);
            //report.ProcessEmployeesWithLessThan30000(emps);

            #region Using  Delegate
            Console.WriteLine("~~~~~Using Delegates~~~~~");
            report.processEmployees(emps, "Sales Greater Than Or Equal 60000", IsGreaterThanOrEqual60000);
            report.processEmployees(emps, "Sales Between 30000 and less than or equal 59000", IsGreaterThan30000AndLessThan59000);
            report.processEmployees(emps, "Sales Less Than 30000", IsGreaterLessThan30000);
            #endregion

            #region Using Anonymous Delegates
            //Console.WriteLine("~~~~~Using Anonymous Delegates~~~~~");
            //report.processEmployees(emps, "Sales Greater Than Or Equal 60000",
            //                               delegate (Employee e) { return e.totalSales > 60000; });

            //report.processEmployees(emps, "Sales Between 30000 and less than or equal 59000",
            //                                delegate (Employee e) { return e.totalSales >= 30000m && e.totalSales <= 59000; });

            //report.processEmployees(emps, "Sales Less Than 30000",
            //                                delegate (Employee e) { return e.totalSales < 30000; });


            #endregion


            #region Using Lambda Expression
            //Console.WriteLine("~~~~~Using Lambda Expression As Delegate~~~~~");
            //report.processEmployees(emps, "Sales Greater Than Or Equal 60000", (Employee e) => e.totalSales >= 60000);
            //report.processEmployees(emps, "Sales Between 30000 and less than or equal 59000", (Employee e) => e.totalSales >= 30000 && e.totalSales <= 59000);
            //report.processEmployees(emps, "Sales Less Than 30000", (Employee e) => e.totalSales < 30000);
            #endregion


            #region MultiTask Delegate
            var rectangleHelper = new RectangleHelper();
            rectangleHelper.GetArea(10, 10);
            rectangleHelper.GetPerimeter(10, 10);
            //Another Defenation => RectangleDelegate rect; || rect = rectangleHelper.GetArea;;

            RectangleDelegate rect = rectangleHelper.GetArea;//Delegate refer to this Method
            rect += rectangleHelper.GetPerimeter;//Delegate refer to this Method and the previous method

            rect(10,10);//Call The Two Methods
            Console.WriteLine("After unsubscriping rect.getArea");
            rect -= rectangleHelper.GetArea; // remove this method from delegate pointer
            rect(10,10);
            #endregion
            Console.ReadKey();
        }

        #region Define Delegates

        #region Delegate For MultiTaskDelegate
        public delegate void RectangleDelegate(decimal width, decimal height);


        #endregion
        static bool IsGreaterThanOrEqual60000(Employee emp)
        {
            return emp.totalSales > 60000m;
        }

        static bool IsGreaterThan30000AndLessThan59000(Employee emp)
        {
            return emp.totalSales >= 30000m && emp.totalSales <= 59000;
        }
        static bool IsGreaterLessThan30000(Employee emp)
        {
            return emp.totalSales < 30000;
        }
        #endregion
    }
}
