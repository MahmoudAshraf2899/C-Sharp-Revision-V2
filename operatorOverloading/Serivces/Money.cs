using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorOverloading.Serivces
{
    internal class Money
    {
        public Money(decimal value)
        {
            this.amount = Math.Round(value, 2);
        }
        private decimal amount;
        public decimal Amount => amount;
        public static Money operator +(Money money1, Money money2)
        {
            return new Money(money1.Amount + money2.Amount);
        }
    }
}
