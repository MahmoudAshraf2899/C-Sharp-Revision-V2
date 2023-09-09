using Records.services;
using System;
using System.Collections.Generic;

namespace Records
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(1, 2);
            var p2 = new Point(1, 2);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine($"p1.equals p2 :{p1.Equals(p2)}");
            Console.WriteLine($"p1 == p2 :{p1 == p2}");
            Console.WriteLine("----To String Feature----");
            var personCopy = new Person("Mahmoud", "Ashraf");
            Console.WriteLine("----Value Before Deconstruct");
            Console.WriteLine(personCopy);
            Console.WriteLine("----Value After Deconstruct");
            personCopy.Deconstruct(out string firstName, out string lastName);
            Console.WriteLine(personCopy);

            Console.WriteLine("----To String Feature----");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Test Add New Instance Of Records");
            var ListOfEmps = new List<Employee>();
            ListOfEmps.Add(new Employee()
            {
                Age = 23,
                firstName = "Mahmoud",
                lastName = "Nabwy"
            });
            foreach (var item in ListOfEmps)
            {
                item.firstName = "Ahmed";
                Console.WriteLine($"Employee Name : {item.firstName} + {item.lastName}");
            }
            Console.WriteLine("Test Add New Instance Of Records");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.ReadKey();
        }


    }
}
