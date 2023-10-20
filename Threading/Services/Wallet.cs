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
            
        }
        public override string ToString()
        {
            return $"[{Name} => {BitCoins} BitCoins]";
        }
    }
}
