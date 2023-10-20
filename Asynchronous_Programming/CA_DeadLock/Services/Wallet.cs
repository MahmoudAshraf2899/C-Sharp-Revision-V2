using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_DeadLock.Services
{
    internal class Wallet
    {
        private readonly object bitCoinsLock = new object();
        public Wallet(string name, int bitcoints)
        {
            Name = name;
            Bitcoints = bitcoints;
        }

        public string Name { get; private set; }
        public int Bitcoints { get; private set; }

        public void Debit(int amount)
        {
            lock (bitCoinsLock)
            {
                if (Bitcoints >= amount)
                {
                    Bitcoints -= amount;
                    Thread.Sleep(1000);
                    Bitcoints -= amount;
                } 
            }
        }
        public void Credit(int amount)
        {
            Thread.Sleep(1000);
            Bitcoints += amount;

        }

        public override string ToString()
        {
            return $"[{Name} => {Bitcoints}]";
        }
    }
}
