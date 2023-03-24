using System;

namespace Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Expressions 
            //Null In Memory
            //S1 Will be stored in Stack But its clear value in Heap 
            string s1 = null;
            string s2 = s1?.ToUpper(); //IF S1 is Null Return Null Else Make The Value To Upper
            Console.WriteLine(s2);
            Console.WriteLine("-------------------------");


            //Switch Statement In C# 8 
            var cardNo = 8;
            var cardName = cardNo switch
            {
                1 => "A",
                2 => "B",
                3 => "C",
                4 => "D",
                5 => "E",
                6 => "F",
                7 => "G",
                8 => "H",
                _ => "NotFound"
            };
            Console.WriteLine($"card Name : {cardName}");
            Console.WriteLine("-------------------------");
            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                    continue;
                Console.WriteLine($"I : {i} ");
                Console.WriteLine("-------------------------");
            }
            #endregion
        }
    }
}
