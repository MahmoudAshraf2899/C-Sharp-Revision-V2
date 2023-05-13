using SortedList_And_HashSet.Services;
using System;

namespace SortedList_And_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer1 = new Customer{Name = "Mahmoud",Telephone = "01148845511"};
            var customer2 = new Customer{Name = "Ahmed",Telephone = "01148845511" };
            var customer3 = new Customer{Name = "Ali",Telephone = "021544148515"};
            var customer4 = new Customer{Name = "Abdo",Telephone = "2515151563"};
            var customer5 = new Customer{Name = "Galal",Telephone = "15051518518"};

            Console.WriteLine(customer1.Equals(customer2));//True
            Console.WriteLine(object.ReferenceEquals(customer1,customer2));//False
            Console.ReadKey();
        }
    }
}
