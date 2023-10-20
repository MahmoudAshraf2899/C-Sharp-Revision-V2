using CA_Sequential.Services;

var wallet = new Wallet("Mahmoud", 80);
wallet.RandomTransaction();
Console.WriteLine("------------");
Console.WriteLine($"{wallet}\n");

wallet.RandomTransaction();
Console.WriteLine("------------");
Console.WriteLine($"{wallet}\n");
Console.ReadKey();