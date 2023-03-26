using Queue.Services;
using System;
using System.Collections.Generic;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<PrintingJob> printingJobs = new Queue<PrintingJob>();
            printingJobs.Enqueue(new PrintingJob("Documentation.docx", 2));
            printingJobs.Enqueue(new PrintingJob("user_stories.pdf", 6));
            printingJobs.Enqueue(new PrintingJob("Report.xlsx", 1));
            printingJobs.Enqueue(new PrintingJob("PayRoll.docx", 3));
            printingJobs.Enqueue(new PrintingJob("Budget.docx", 5));
            printingJobs.Enqueue(new PrintingJob("Algorithms.ppt", 4));

            Random random = new Random();
            while (printingJobs.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                var job = printingJobs.Dequeue();//سحب اول عنصر دخل
                Console.WriteLine($"Printing ... {job}");
                System.Threading.Thread.Sleep(random.Next(1, 5) * 1000);
            }
            Console.WriteLine($"Current Queue Count : {printingJobs.Count}");
            Console.ReadKey();
        }
    }
}
