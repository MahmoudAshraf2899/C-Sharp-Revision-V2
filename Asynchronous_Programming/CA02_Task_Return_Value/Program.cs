Task<DateTime> task = Task.Run(() => getCurrentDateTime());
Console.WriteLine(task.Result); //task.result makes block to thread
Console.WriteLine(task.GetAwaiter().GetResult());  
Console.ReadKey();

static DateTime getCurrentDateTime() => DateTime.Now;