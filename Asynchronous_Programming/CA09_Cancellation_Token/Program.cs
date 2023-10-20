CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
await DoCheck01(cancellationTokenSource);
Console.ReadKey();

static async Task DoCheck01(CancellationTokenSource cancellationTokenSource)
{
    Task.Run(() =>
    {
        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Q)
        {
            cancellationTokenSource.Cancel();
            Console.WriteLine($"Task has been canceled");
        }

    });
    while (!cancellationTokenSource.Token.IsCancellationRequested)//If is canceled == false (No Body Cancel The Request)
    {
        Console.Write("Checking ...");
        await Task.Delay(4000);
        Console.Write($"Completed on {DateTime.Now}");
        Console.WriteLine();
    }
    Console.WriteLine("Check Was Terminated");
    cancellationTokenSource.Dispose();
}