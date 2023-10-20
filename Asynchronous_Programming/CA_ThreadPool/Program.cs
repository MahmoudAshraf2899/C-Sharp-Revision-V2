//#-1
ThreadPool.QueueUserWorkItem(new WaitCallback(Print));
Console.ReadKey();

void Print(object? state)
{
    Console.WriteLine($"Thread Id : {Thread.CurrentThread.ManagedThreadId}, Thread Name: {Thread.CurrentThread.Name}");

    Console.WriteLine($"Is Pool Thread : {Thread.CurrentThread.IsThreadPoolThread}");

    Console.WriteLine($"Background: {Thread.CurrentThread.IsBackground}");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Cycle => {i + 1}");
    }
}