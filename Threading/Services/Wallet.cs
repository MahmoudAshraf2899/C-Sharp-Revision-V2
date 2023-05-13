using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading.Services
{
    internal class Wallet
    {
        public Wallet(string name, int bitCoins)
        {
            Name = name;
            BitCoins = bitCoins;
        }

        public string Name { get; private set; }
        public int BitCoins { get; private set; }
        public void Debit(int amount)
        {
            BitCoins -= amount;
        }
        public void Credit(int amount)
        {
            BitCoins += amount;
        }
        public void RandomTransaction()
        {
            int[] amounts = { 10, 20, 30, -20, 10, -10, 30, -10, 40, -20 };
            foreach (var amount in amounts)
            {
                var absValue = Math.Abs(amount);
                if (amount < 0)
                    Debit(absValue);

                else
                    Credit(absValue);
                Console.WriteLine($"[Thread :{Thread.CurrentThread.ManagedThreadId}" +
                                   $",Processor Id : {Thread.GetCurrentProcessorId()}] {amount}");

            }
        }
        public override string ToString()
        {
            return $"[{Name} => {BitCoins} BitCoins]";
        }
    }
}
