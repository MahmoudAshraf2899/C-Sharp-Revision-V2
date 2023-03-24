using System;

namespace Enumerators_Iterators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee { Id = 100, Name = "Mahmoud", Department = "Development", salary = 4500m };
            Employee e2 = new Employee { Id = 100, Name = "Mahmoud", Department = "Development", salary = 4500m };
            Employee e3 = e1;


            // Out Put is false because it compare between refernces (before using override)
            //Out Put is true after using override
            Console.WriteLine(e1 == e2);
            Console.WriteLine(e1 == e3);

            //لو عاوز اقارن المحتوي بتاع الاوبجيكت
            // Out Put is false because it still compare between refernces (before doing override)
            //If We Need Equal to excatly compare between the values we should override it
            Console.WriteLine(e1.Equals(e2));//Out Put is True
            var s1 = "Hello";
            var s2 = "Hello";
            Console.WriteLine(s1 == s2); //Out Put is True : Here it also compare between refernces but it's special case for string

            //Note : Each Object Has Unique Hash Code
            Console.WriteLine(7.GetHashCode());


            #region IEnumerator

            var ints = new FiveIntegers(1, 2, 3, 4, 5);
            foreach (var i in ints)
            {
                Console.WriteLine(i);
            }

            #endregion

        }
    }

}
