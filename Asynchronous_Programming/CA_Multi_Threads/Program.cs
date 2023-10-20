//Naming The Thread
using CA_Multi_Threads.Services;

Thread.CurrentThread.Name = "Main Thread";
Console.WriteLine(Thread.CurrentThread.Name);
Console.WriteLine($"Background Thread :{Thread.CurrentThread.IsBackground}");

//Create New Thread #1
var wallet = new Wallet("Mahmoud", 80);
Thread T1 = new Thread(wallet.RandomTransaction);
T1.Name = "Thread One";
Console.WriteLine($"Before start {T1.Name} state is : {T1.ThreadState}");

T1.Start();
Console.WriteLine($"After start {T1.Name} state is : {T1.ThreadState}");
T1.Join();

Console.WriteLine($"Current Thread is : {Thread.CurrentThread.Name}");


//Create New Thread #2
Thread T2 = new Thread(new ThreadStart(wallet.RandomTransaction));
T2.Name = "Thread Two";

T2.Start();
Console.WriteLine($"After start {T2.Name} state is : {T2.ThreadState}");
Console.WriteLine($"Current Thread is : {Thread.CurrentThread.Name}");
Console.ReadKey();