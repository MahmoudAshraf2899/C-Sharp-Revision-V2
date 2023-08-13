using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Dictionaries_V2.Services
{
    internal class Country
    {
        public string ISOCode { get; set; }
        public string Name { get; set; }


        public static void print(List<Country> countries)
        {
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }
            //Print Props Of List
            Console.WriteLine($"Count Is :{countries.Count}");//actual count
            Console.WriteLine($"Capacity Is:{countries.Capacity}");
            Console.ReadKey();
        }

        public override string ToString()
        {
            return $"{Name} ({ISOCode})";
        }
    }
}
