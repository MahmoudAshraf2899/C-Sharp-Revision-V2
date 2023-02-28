using System;

namespace Inhertitance_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager
            {
                Id =1000,
                LoggedHours = 180,
                Wage =10,
                Name = "Ali"
            };
            Console.WriteLine(manager);
        }
    }
}
