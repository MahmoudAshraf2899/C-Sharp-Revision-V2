using OOP.Services;
using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Field & Constant
            const double TAX = 0.03;

            Console.Write("First Name : ");
            var fName = Console.ReadLine();
            Console.Write("last Name : ");
            var lName = Console.ReadLine();
            Console.Write("Wage :");
            var wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Logged Hours :");
            var loggedHours = Convert.ToDouble(Console.ReadLine());
            var netSalary = wage * loggedHours - (wage * loggedHours * TAX);
            Console.WriteLine($"First Name is {fName}");
            Console.WriteLine($"Last Name is {lName}");
            Console.WriteLine($"Wage is {wage}");
            Console.WriteLine($"Logged Hours is {loggedHours}");
            Console.WriteLine($"Net Salary is {netSalary}");

            //4 Principles of Object-Oriented Programming
            //1- Encapsulation التحزيم او التغليف
            //2- Inheritance الوراثة 
            //3- Polymorphism تعدد الاشكال
            //4- Abstraction التجريد

            //Object is an instance of a class.
            //Employee empObj; //Decleration
            Employee empObj = new Employee();
            empObj.fName = Console.ReadLine();
            empObj.lName = Console.ReadLine();
            empObj.wage = Convert.ToDouble(Console.ReadLine());
            empObj.loggedHours = Convert.ToDouble(Console.ReadLine());

            ////What Happend In Memory ?
            ////Ans : in Stack we store empObj 
            ////in Heap We Store The Values
            ////So The Class and Object are reference type ^_^

            var newNetSalary = empObj.wage * empObj.loggedHours - (empObj.wage * empObj.loggedHours * Employee.TAX);
            Console.WriteLine($"Object First Name is {empObj.fName}");
            Console.WriteLine($"Object Last Name is {empObj.lName}");
            Console.WriteLine($"Object Wage is {empObj.wage}");
            Console.WriteLine($"Object Logged Hours is {empObj.loggedHours}");
            Console.WriteLine($"Object Net Salary is {newNetSalary}");


            #endregion
        }
    }
}
