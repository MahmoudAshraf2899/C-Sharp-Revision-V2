using Linked_Lists.Services;
using System;
using System.Collections.Generic;

namespace Linked_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lesson1 = new YoutubeVideo { Id = 1, Duration = new TimeSpan(00, 30, 00), Title = "First Video" };
            var lesson2 = new YoutubeVideo { Id = 2, Duration = new TimeSpan(00, 40, 00), Title = "Second Video" };
            var lesson3 = new YoutubeVideo { Id = 3, Duration = new TimeSpan(00, 50, 00), Title = "Third Video" };
            var lesson4 = new YoutubeVideo { Id = 4, Duration = new TimeSpan(00, 60, 00), Title = "Fourth Video" };

            YoutubeVideo[] collectionOfPlayListVideos = new YoutubeVideo[]
            {
                lesson1,
                lesson2,
                lesson3,
                lesson4,
            };
            LinkedList<YoutubeVideo> playList = new LinkedList<YoutubeVideo>(collectionOfPlayListVideos);
            Print("C# From Zero To Hero", playList);
            Console.ReadKey();
        }
        static void Print(string title, LinkedList<YoutubeVideo> playList)
        {
            Console.WriteLine($"First Lesson In PLay List Is {playList.First.Value.Title}");
            Console.WriteLine($"┌{title}");
            foreach (var item in playList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"└");
            Console.WriteLine($"First Lesson In PLay List Is {playList.Last.Value.Title}");
            

        }
    }
}
