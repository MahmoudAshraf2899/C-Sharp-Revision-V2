using System;

namespace Working_with_NULL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Type of erros
            //string input = "123A";
            ////Compile Time Error : Cannot build Source Code and convert it to IL 
            //int num1 = input;

            ////Run Time Error : It Happen When We Excute The Compiled Code..
            //int num2 = int.Parse(input); 
            #endregion

            #region Work With Reference type and value type
            ////String Is Reference type
            //string str1 = default; // default is null ==> string str1 = null
            ////Reference Type
            //string str2 = "mahmoud";
            //Console.WriteLine(str1.Length); //Null Reference Exception
            //Console.WriteLine(str2.Length); //6

            ////Value Type
            //DateTime dateTime = default; //Default value of date time (0001/01/01 00:00AM);
            //Console.WriteLine(dateTime.Month);//01 
            #endregion

            #region MyRegion
            //int mark1 = 15;
            //int mark2 = default; //It Will Return 0;

            //Nullable<int> mark3 = default;
            //if (mark3 is null)
            //{
            //    Console.WriteLine("Not Available");
            //}
            //else
            //{
            //    Console.WriteLine($"Mark is {mark3}");
            //}
            //int? mark4 = default;

            //if (mark4.HasValue)
            //{
            //    Console.WriteLine($"Mark 4 Value is : {mark4}");
            //}
            //else
            //{
            //    Console.WriteLine("Mark 4 Not Available");
            //} 
            #endregion

            #region Work With Null Reference Type
            string? name = null;
            string decision = isLongName(name) ? "Long" : "Short";


            #endregion

            Console.ReadKey();
        }
        static bool isLongName(string? name)
        {
            if (name is null)
                return false;

            return name.Length > 10;
        }
    }
}
