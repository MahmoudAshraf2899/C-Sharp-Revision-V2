using System;
using System.Diagnostics;
using System.Threading;
using Threading.Services;

namespace Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //Console.WriteLine($"Process Id : {Process.GetCurrentProcess().Id}");
            //Console.WriteLine($"Thread Id : {Thread.CurrentThread.ManagedThreadId}");
            //Console.WriteLine($"Processor Id : {Thread.GetCurrentProcessorId()}"); 
            #endregion

            #region Sequential
            var wallet = new Wallet("Mahmoud", 55);
            wallet.RandomTransaction();
            Console.WriteLine("--------------------");
            Console.WriteLine($"{wallet}\n");


            wallet.RandomTransaction();
            Console.WriteLine("--------------------");
            Console.WriteLine($"{wallet}\n");

            #endregion
            #region Declare Thread

            Thread t1 = new Thread(wallet.RandomTransaction);
            t1.Name = "t1";
            t1.Start();

            #endregion
            Console.ReadKey();
        }
    }
}
