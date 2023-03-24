using property_And_Encapsulation.Services;
using System;

namespace property_And_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Property & Encapsulation
            //Property Promote Encapsulation بتعزز التغليف
            //Get : Allow Us To Read The Value of the Property
            //Set : Allow Us To Assign Value To The Property
            Dollar dollar = new Dollar(1.95m);
            dollar.Amount = 1.99m;
            Console.WriteLine($"Get : {dollar.Amount}");
            dollar.Amount = 12.5m;
            Console.WriteLine($"Set : {dollar.Amount}");
            #endregion
        }
    }
}
