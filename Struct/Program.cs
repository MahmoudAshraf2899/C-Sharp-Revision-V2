using Struct.Services;
using System;

namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Struct Doesn't Implement Inheritance
            //I Can't inherit from struct
            //struct cannot inherit from any type

            Employee emp = new Employee();
            emp.firstName = "Ahmed";
            emp.lastName = "Mahmoud";
            emp.salary = 10;
            Console.WriteLine($"Employee : {emp.lastName}");
        }
    }
}
