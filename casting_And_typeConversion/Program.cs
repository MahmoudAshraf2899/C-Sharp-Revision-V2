using System;

namespace casting_And_typeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion 
            //int z = 10;
            //string str = z; //We Cannot Do That because c# is Strongly Types Language

            //We Can Convert Value Type To Reference Type in Implicity Way
            int x = 10; //Value Type
            Object obj; //Reference Type
            //حطيت الاكس جوا الأوبجيكت
            obj = x; //Boxing : From Value To Reference 
            int y = (int)obj; //UnBoxing : From Reference To Value


            //Convert from String To Number
            string stringValue = "120";
            //First By Using type.Parse
            int number = int.Parse(stringValue); // It Will Parse Correctly 
            string strongValue = "w150";
            int number2 = int.Parse(strongValue); // It Will Got Exception Error
            if (int.TryParse(strongValue, out int number3))
            {
                Console.WriteLine($"Try Parse Result{number3}");
                Console.WriteLine("-------------------------");
            }
            else
                Console.WriteLine($"InValid Number Format");

            //Second By Using Convert Class
            var number4 = Convert.ToInt32(strongValue); //Exception
            //Int.Parse is The best Performance 

            //Bit Converter
            var number5 = 255;
            var bytes = BitConverter.GetBytes(number5);
            foreach (var item in bytes)
            {
                Console.WriteLine($"Bytes Converter Result : {item}");
            }
        }
    }
}
