using Events.Services;
using System;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock("Amazon");
            stock.Price = 100;
            stock.onPriceChanged += Stock_onPriceChanged;
            stock.ChangeStockPrice(0.05m);
            stock.ChangeStockPrice(-0.03m);
            stock.ChangeStockPrice(0.00m);
            //Un Subscripe From Event
            stock.onPriceChanged -= Stock_onPriceChanged;
            stock.ChangeStockPrice(0.04m);
            stock.ChangeStockPrice(0.03m);
        }
        private static void Stock_onPriceChanged(Stock stock, decimal oldPrice)
        {
            if (stock.Price > oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (oldPrice > stock.Price)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;

            }
            Console.WriteLine($"{stock.Name} : {stock.Price}");
        }
    }
}
