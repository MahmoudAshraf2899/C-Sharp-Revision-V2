using System;

namespace ProjectOne
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            #region Indexers
            int[] array = { 0, 1, 2 };
            array[0] = 10; //0 is Index
            //int data type doesn't has indexers
            var ip = new IPAddress(119, 125, 451, 122);
            Console.WriteLine($"IP :{ip.Address}");
            #endregion            
            Console.ReadLine();
        }                  
    }
}