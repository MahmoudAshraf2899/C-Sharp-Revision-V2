using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Sequential.Services
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
        }
        public void Credit(int amount)
        {
            Bitcoints += amount;
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
                Console.WriteLine($"[Thread: {Thread.CurrentThread.ManagedThreadId}" +
                                    $",Processor Id : {Thread.GetCurrentProcessorId()}]{item}");
            }
        }
        public override string ToString()
        {
            return $"[{Name} => {Bitcoints}]";
        }
    }
}
