ShowThreadInfo(Thread.CurrentThread, 1);
CallSync();

ShowThreadInfo(Thread.CurrentThread, 4);
CallAsync();

ShowThreadInfo(Thread.CurrentThread, 7);
Console.ReadKey();



static void CallSync()
{
    Thread.Sleep(4000);
    ShowThreadInfo(Thread.CurrentThread, 15);
    //Wait here : make the method work in Synchronous
    Task.Run(() => Console.WriteLine("++++++++++++ Synchronous ++++++++++++")).Wait();
}
static void CallAsync()
{

    ShowThreadInfo(Thread.CurrentThread, 22);
    Task.Delay(4000).GetAwaiter().OnCompleted(() =>
    {
        ShowThreadInfo(Thread.CurrentThread, 25);
        Console.WriteLine("++++++++++++ Asynchronous ++++++++++++");
    });
}
static void ShowThreadInfo(Thread currentThread, int lineNumber)
{
    Console.WriteLine($"Line Number: {lineNumber} & Thread Id : {currentThread.ManagedThreadId} , Pooled : {currentThread.IsThreadPoolThread} ,Backgrounded : {currentThread.IsBackground}");

}