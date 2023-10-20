//Create Custom Thread
var th = new Thread(() => display("Dummy Text 1"));
th.Start();
th.Join();
//Task is abstracted From Thread
Task.Run(() => display("Dummy Text From Task")).Wait();


// display("Dummy Text 2");
Console.ReadKey();

static void display(string msg)
{
    Console.WriteLine(msg);
    ShowThreadInfo(Thread.CurrentThread);

}

static void ShowThreadInfo(Thread currentThread)
{
    Console.WriteLine($"Thread Id : {currentThread.ManagedThreadId} , Pooled : {currentThread.IsThreadPoolThread} ,Backgrounded : {currentThread.IsBackground}");

}