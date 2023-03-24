using Methods.Services;
using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //The Difference between Static and Constant
            //Ans :
            //Static : قيمته ثابته للجميع ولكن اقدر اغيرها
            //Constant : قيمته ثابته للجميع لكن مقدرش اغيرها         
            var NetSalary = 0.0;
            Employee[] emps = new Employee[2];
            Console.WriteLine("TAX :");
            Employee.TAX = Convert.ToDouble(Console.ReadLine());
            Employee emp1 = new Employee();
            Console.WriteLine("First Names Is :");
            emp1.fName = Console.ReadLine();
            Console.WriteLine("Last Names Is :");
            emp1.lName = Console.ReadLine();
            Console.WriteLine("Wage Is :");
            emp1.wage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Logged Hours Is :");
            emp1.loggedHours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nSecond Employee");
            Employee emp2 = new Employee();
            Console.WriteLine("First Names Is :");
            emp2.fName = Console.ReadLine();
            Console.WriteLine("Last Names Is :");
            emp2.lName = Console.ReadLine();
            Console.WriteLine("Wage Is :");
            emp2.wage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Logged Hours Is :");
            emp2.loggedHours = Convert.ToDouble(Console.ReadLine());
            emps[0] = emp1;
            emps[1] = emp2;
            foreach (var emp in emps)
            {
                NetSalary = emp.wage * emp.loggedHours - (emp.wage * emp.loggedHours * Employee.TAX);
            }

            Console.WriteLine($"Total Net Salary is : {NetSalary}");


            Demo demo = new Demo();
            //var age = 18;
            //demo.doSomething(ref age);
            //Console.WriteLine($"Age After Reference : {age}"); //Age Will be 21 because we use ref else it will be 18
            double promote = 50.0;
            string trip = "Turkey";
            string hotel = "Kembiniski";
            demo.promoteIncrease(promote, trip, hotel);


        }
    }
}
