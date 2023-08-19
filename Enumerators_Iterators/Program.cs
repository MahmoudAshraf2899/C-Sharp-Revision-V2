using System;
using System.Collections;

namespace Enumerators_Iterators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee { Id = 100, Name = "Mahmoud", Department = "Developers", salary = 15000 };
            Employee e2 = new Employee { Id = 100, Name = "Mahmoud", Department = "Developers", salary = 15000 };
            Employee e3 = e1;
            Console.WriteLine(e1 == e2);//False before override
            Console.WriteLine(e1 == e3);//True before override
            Console.WriteLine(e1.Equals(e2));//True

            Console.WriteLine(e1 == e2);//True after override
            Console.WriteLine(e1 == e3);//True after override


            Console.WriteLine(7.GetHashCode());//7
            

            var ints = new FiveIntegers(1, 2, 3, 4, 5);
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();



        }
    }

}
