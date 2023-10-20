using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Multi_Threads.Services
{
    internal class Wallet
    {
        public Wallet(string name, int bitcoints)
        {
            Name = name;
            Bitcoints = bitcoints;
        }

        public string Name { get; private set; }
        public int Bitcoints { get; private set; }

        public void Debit(int amount)
        {
            Bitcoints -= amount;
            Console.WriteLine($"[Thread: {Thread.CurrentThread.ManagedThreadId} ----" + $"Current Thread Name: {Thread.CurrentThread.Name}" +
                                   $",Processor Id : {Thread.GetCurrentProcessorId()}] -{amount}");
        }
        public void Credit(int amount)
        {
            Thread.Sleep(1000);
            Bitcoints += amount;
            Console.WriteLine($"[Thread: {Thread.CurrentThread.ManagedThreadId} ----" + $"Current Thread Name: {Thread.CurrentThread.Name}" +
                                   $",Processor Id : {Thread.GetCurrentProcessorId()}] +{amount}");
        }
        public void RandomTransaction()
        {
            int[] amounts = { 10, 20, 30, -20, 10, -10, 30, -10, 40 - 20 };
            foreach (var item in amounts)
            {
                var absValue = Math.Abs(item);
                if (item < 0)
                {
                    Debit(absValue);
                }
                else
                {
                    Credit(absValue);
                }

            }
        }
        public override string ToString()
        {
            return $"[{Name} => {Bitcoints}]";
        }
    }
}
