using operatorOverloading.Serivces;
using System;

namespace operatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money m1 = new Money(10.5m);
            Money m2 = new Money(20);
            Console.WriteLine($"Money One : {m1.Amount} , Money Two : {m2.Amount}");
            Money m3 = m1 + m2;
            Console.WriteLine($"Money Three Using Operator : {m3.Amount}");
        }
    }
}
