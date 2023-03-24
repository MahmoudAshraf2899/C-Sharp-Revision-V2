using System;

namespace Events.Services
{
    internal class Stock
    {
        private string name;
        private decimal price;

        public event StockPriceChangeHandler onPriceChanged;

        public string Name => this.name;
        public decimal Price { get => this.price; set => this.price = value; }
        public Stock(string stockName)
        {
            this.name = stockName;
        }
        public void ChangeStockPrice(decimal percent)
        {
            decimal oldPrice = this.price;

            this.price += Math.Round(this.price * percent, 2);
            if (onPriceChanged != null)//Make Sure That event has Subscribe
            {
                //This Refer to This Class
                onPriceChanged(this, oldPrice);
            }
        }
        public delegate void StockPriceChangeHandler(Stock stock, decimal oldPrice);
    }
}
