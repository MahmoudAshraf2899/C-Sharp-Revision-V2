using Linked_Lists.Services;
using System;
using System.Collections.Generic;

namespace Linked_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var video1 = new YoutubeVideo { Id = 1, Title = "Video 1", Duration = new TimeSpan(00, 30, 00) };
            var video2 = new YoutubeVideo { Id = 2, Title = "Video 2", Duration = new TimeSpan(00, 40, 00) };
            var video3 = new YoutubeVideo { Id = 3, Title = "Video 3", Duration = new TimeSpan(00, 50, 00) };
            var video4 = new YoutubeVideo { Id = 4, Title = "Video 4", Duration = new TimeSpan(00, 60, 00) };
            var video5 = new YoutubeVideo { Id = 5, Title = "Video 5", Duration = new TimeSpan(00, 70, 00) };
            var video6 = new YoutubeVideo { Id = 6, Title = "Video 6", Duration = new TimeSpan(00, 80, 00) };
            var video7 = new YoutubeVideo { Id = 7, Title = "Video 7", Duration = new TimeSpan(00, 90, 00) };

            //Create Linked List
            #region First Case To Create Linked List 
            YoutubeVideo[] collection = new YoutubeVideo[]
                {
                video1,
                video2,
                video3,
                video4,
                video5,
                video6,
                video7};
            LinkedList<YoutubeVideo> playList = new LinkedList<YoutubeVideo>(collection);
            Print("C# From Zero To Hero", playList, true);
            #endregion

            #region Second Case To Create Linked List
            LinkedList<YoutubeVideo> youtubeVideosList = new LinkedList<YoutubeVideo>();
            youtubeVideosList.AddFirst(video1);
            youtubeVideosList.AddAfter(youtubeVideosList.First, video2);
            var node3 = new LinkedListNode<YoutubeVideo>(video3);
            youtubeVideosList.AddAfter(youtubeVideosList.First.Next, node3);
            youtubeVideosList.AddBefore(youtubeVideosList.Last, video6);
            youtubeVideosList.AddLast(video7);
            Print("C# From Zero To Hero Second Case", youtubeVideosList, false);
            #endregion
            Console.ReadKey();
        }
        static void Print(string title, LinkedList<YoutubeVideo> playList, bool firstCase)
        {
            if (firstCase)
            {
                Console.WriteLine($"┌ Title : {title}");
                foreach (var item in playList)
                {
                    Console.WriteLine($"Item : {item}");
                }
                Console.WriteLine("└");

            }
            else
            {
                Console.WriteLine($"┌ Title : {title}");
                foreach (var item in playList)
                {
                    Console.WriteLine($"Item : {item}");
                }
                Console.WriteLine("└");
                Console.WriteLine($"Total : {playList.Count} items");
            }
        }
    }
}
