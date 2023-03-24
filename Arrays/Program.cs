using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            //Arrays Are Reference Type

            #region  Single Dimensional Array
            string[] friends = new string[5];//Friends Will be stored in Stach and The Five Elements will be in Heap
            friends[0] = "Mahmoud";
            friends[1] = "Ashraf";
            friends[2] = "Mohamed";
            friends[3] = "Elnabwy";
            friends[4] = "Radwan";
            Console.WriteLine("Friends :", friends);
            #endregion
            Console.WriteLine("-------------------------");

            #region Multi Dimensional Array [rectangular array]

            int[,] suduko =
            {
                {9,6,2,1,4,7,3,7,8 },
                {1,8,5,1,4,7,3,7,8 },
                {5,3,1,1,4,7,3,7,8 },
                {6,9,4,1,4,7,3,7,8 },
                {3,7,4,1,4,7,3,7,8 },
                {8,2,7,1,4,7,3,7,8 },
                {4,9,6,1,4,7,3,7,8 },
                {2,1,8,1,4,7,3,7,8 },
                {7,5,3,1,4,7,3,7,8 },
            };
            foreach (var item in suduko)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");

            #endregion

            #region Jagged Array
            //Jagged Array => Array Inside Array
            var jagged = new int[][]
            {
                new int [] {1,2},
                new int [] {2,5,6},
                new int [] { 7,3  }
            };
            Console.WriteLine("jagged[1][0]: " + jagged[1][0]);//1 Refer To Array Of Index 1 || 0 Refer to first index in Array Of Index one
            Console.WriteLine("-------------------------");

            #endregion

            #region Indices And Ranges
            var subject = new string[] { "Math", "Introduction TO CS", "Logic Design", "Operating System" };
            var first = subject[0]; //Indices مؤشر
            Console.WriteLine($"First : {first}");
            Console.WriteLine("-------------------------");
            var slicefirstTwoElements = subject[..2]; //Slice => It Will Return just first two elements
            foreach (var item in slicefirstTwoElements)
                Console.WriteLine($"slicefirstTwoElements : {item}");
            Console.WriteLine("-------------------------");

            var skipFirstTwoElements = subject[2..];
            foreach (var element in skipFirstTwoElements)
                Console.WriteLine($"skipFirstTwoElements : {element}");
            Console.WriteLine("-------------------------");

            var startFromTwoAndTakeUntilThree = subject[2..3];
            foreach (var element in startFromTwoAndTakeUntilThree)
                Console.WriteLine($"startFromTwoAndTakeUntilThree : {element}");
            Console.WriteLine("-------------------------");

            //We Here Start From End Of Array 
            //Because We Use ^ (Shapo)
            //And It Make Us Count From 1 Not Zero Index..
            var array = new string[] { "A", "B", "C", "D", "E", "F" };
            var shapo = array[2..^2];
            foreach (var item in shapo)
                Console.WriteLine($"Shapo : {item}");
            Console.WriteLine("-------------------------");




            #endregion

            #endregion
        }
    }
}
