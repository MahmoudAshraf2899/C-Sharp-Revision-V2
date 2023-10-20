using CA_Race_Condition.Services;

var wallet = new Wallet("Mahmoud", 50);
var t1 = new Thread(() => wallet.Debit(40));
var t2 = new Thread(() => wallet.Debit(40));
t1.Start();
t2.Start();
t1.Join();
t2.Join();
Console.WriteLine(wallet);
Console.ReadKey();
