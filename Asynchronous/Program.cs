using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            #region Task (Return Type From Task)
            //Task<DateTime> task = Task.Run(GetCurrentDateTime);
            //Console.WriteLine($"Task Result : {task.Result}");//results : Block thread until results is ready 
            #endregion

            #region Long Running Task
            //var factory = Task.Factory.StartNew(() => RunLongTask(),TaskCreationOptions.LongRunning);

            #endregion

            #region async - Task
            #region Old Code
            //var task = Task.Run(() => ReadContent("https://youtu.be/kDUDX3VJFEc?list=PL4n1Qos4Tb6SWPbJNpiznp-Ok4A8J_23l"));
            //var awaiter = task.GetAwaiter();
            //awaiter.OnCompleted(() => Console.WriteLine(awaiter.GetResult())); 
            #endregion
            #region New Code Using async keyword
            //var content = await ReadContentAsync("https://youtu.be/kDUDX3VJFEc?list=PL4n1Qos4Tb6SWPbJNpiznp-Ok4A8J_23l");
            //Console.WriteLine(content);
            #endregion
            #endregion

            Console.ReadKey();
        }
        static Task<string> ReadContent(string url)
        {
            var client = new HttpClient();
            var task = client.GetStringAsync(url);
            return task;
        }
        static async Task<string> ReadContentAsync(string url)
        {
            var client = new HttpClient();
            var content = await client.GetStringAsync(url);
            return content;
        }
        static void RunLongTask()
        {
            Thread.Sleep(3000);
            ShowThreadInfo(Thread.CurrentThread);
            Console.WriteLine("Completed");
        }
        static void ShowThreadInfo(Thread th)
        {
            Console.WriteLine($"TID : {th.ManagedThreadId}, Pooled : {th.IsThreadPoolThread}");
        }
        static DateTime GetCurrentDateTime() => DateTime.Now.Date;
    }
}
