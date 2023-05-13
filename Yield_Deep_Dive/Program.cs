using System;
using System.Collections.Generic;

namespace Yield_Deep_Dive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generate List V1 Results");
            foreach (var item in GenerateListV1())
            {
                Console.Write($"{item}");
            }


            Console.WriteLine("Generate List V2 Results");
            foreach (var item in GenerateListV2())
            {
                Console.Write($"{item}");
            }
        }
        static IEnumerable<int> GenerateListV1()
        {
            var result = new List<int>();
            for (int i = 0; i <= 5; i++)
            {
                result.Add(i);
            }
            return result;
        }

        static IEnumerable<int> GenerateListV2()
        {
            for (int i = 0; i <= 5; i++)
            {
                yield return i;
            }
        }

    }
}
