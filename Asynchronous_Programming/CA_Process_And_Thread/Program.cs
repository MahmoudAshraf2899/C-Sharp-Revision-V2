using System.Diagnostics;
using System.Threading;
//Each Dot Net App Has One Thread To The Process
Console.WriteLine($"Process Id: {Process.GetCurrentProcess().Id}");
Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}");
Console.WriteLine($"Processor Id: {Thread.GetCurrentProcessorId()}"); //Refer to which processor on my Device The App Has Reserved
Console.ReadKey();