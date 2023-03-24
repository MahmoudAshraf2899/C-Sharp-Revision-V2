using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_And_Encapsulation.Services
{
    internal class Dollar
    {
        private decimal _amount;
        public decimal Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = processValue(value);
            }
        }
        public Dollar(decimal amount)
        {
            this._amount = processValue(amount);
        }
        private decimal processValue(decimal value) => value <= 0 ? 0 : Math.Round(value, 2);
    }
}
