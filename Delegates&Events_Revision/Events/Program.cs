using Events.Services;

var stock = new Stock("Amazon");
stock.Price = 100;
Console.WriteLine($"Stock Before changing : ${stock.Price}");
stock.ChangeStockPriceBy(0.05m);
Console.WriteLine($"Stock After changing : ${stock.Price}");
Console.ReadKey();