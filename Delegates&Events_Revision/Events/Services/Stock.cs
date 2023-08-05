using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Services
{
    public class Stock
    {
        private string name;
        private decimal price;

        public string Name => this.name;
        public decimal Price { get => this.price; set => this.price = value; }

        public Stock(string stockName)
        {
            this.name = stockName;
        }
        public void ChangeStockPriceBy(decimal percent)
        {
            this.price += Math.Round(this.price * percent, 2);
        }

    }
}
