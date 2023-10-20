using CA_DeadLock.Services;

var wallet1 = new Wallet("Mahmoud", 100);
var wallet2 = new Wallet("Hager", 50);
Console.WriteLine($"\n Before Transaction");
Console.WriteLine("\n--------------------------");
Console.Write(wallet1 + " ,"); Console.Write(wallet2);
Console.WriteLine();
Console.WriteLine($"\n After Transaction");
Console.WriteLine("\n--------------------------");

var transferManager = new TransferManager(wallet1, wallet2, 50);
 


var transferManager2 = new TransferManager(wallet2, wallet1, 30);
 
var t1 = new Thread(transferManager.Transfer);
t1.Name = "Thread One";
var t2 = new Thread(transferManager2.Transfer);
t2.Name = "Thread Two";

t1.Start();
t2.Start();

t1.Join();
t2.Join();

Console.Write(wallet1 + " ,"); Console.Write(wallet2);
Console.WriteLine();


Console.ReadKey();