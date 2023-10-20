var task = Task.Factory.StartNew(() => RunLongTask(), TaskCreationOptions.LongRunning);
Console.ReadKey();

static void RunLongTask()
{
    Thread.Sleep(3000);
    ShowThreadInfo(Thread.CurrentThread);
    Console.WriteLine("Completed");
}
static void ShowThreadInfo(Thread currentThread)
{
    Console.WriteLine($"Thread Id : {currentThread.ManagedThreadId} , Pooled : {currentThread.IsThreadPoolThread} ,Backgrounded : {currentThread.IsBackground}");

}
 
