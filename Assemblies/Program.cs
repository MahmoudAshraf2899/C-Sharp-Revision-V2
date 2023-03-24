using System;

namespace Assemblies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assemblies");
            var type = typeof(Employee);
            var assembly = type.Assembly;
            Console.WriteLine($"Assembly is : {assembly}");
            Console.ReadKey();
        }
    }
    class Employee
    {

    }
}
