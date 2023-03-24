using System;

namespace ENUM
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Enum is {Month.JAN}");
            var day = "FEB";
            if (Enum.TryParse(day, out Month month))
            {

                Console.WriteLine(Enum.Parse(typeof(Month), day));
                Console.WriteLine("--------------------------------------");
            }

        }
    }
}
