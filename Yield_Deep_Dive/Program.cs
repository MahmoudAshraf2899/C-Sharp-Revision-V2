using System;
using System.Collections.Generic;

namespace Yield_Deep_Dive
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Using GenerateV1");
            foreach (var item in GenerateV1())
            {
                Console.WriteLine($" {item}");
            }

            Console.WriteLine("Using GenerateV2");
            foreach (var item in GenerateV2())
            {
                Console.WriteLine($" {item}");
            }

            Console.WriteLine("Using GenerateV3");
            foreach (var item in GenerateV3())
            {
                Console.WriteLine($" {item}");
            }
        }
        static IEnumerable<int> GenerateV1()
        {
            var result = new List<int>();
            for (int i = 1; i < 5; i++)
            {
                result.Add(i);
            }
            return result;
        }

        static IEnumerable<int> GenerateV2()
        {
            var result = new List<int>();
            for (int i = 1; i < 5; i++)
            {
                yield return i;
            }

        }
        static IEnumerable<int> GenerateV3()
        {

            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;


        }

    }
}
