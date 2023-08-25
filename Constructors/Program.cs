using Constructors.Services;
using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Date date1 = new(29, 02, 2000);
            //date1.setValue(01, 01, 1999);// to avoid that we create method to send values we make constructor 
            Console.WriteLine(date1.GetDate());
            Employee employee1 = new Employee();
            employee1.id = 1;
            employee1.firstName = "Mahmoud";
            employee1.lastName = "Nabwy";

            Employee employee2 = new Employee()
            {
                id = 2,
                firstName="Ahmed",
                lastName = "Ali"
            };
            




        }
    }
}
