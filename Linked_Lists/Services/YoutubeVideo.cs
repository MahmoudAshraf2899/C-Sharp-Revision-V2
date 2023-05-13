using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Lists.Services
{
    internal class YoutubeVideo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public override string ToString()
        {
            return $"├── {Title} ({Duration})\n|\thttps://www.youtube.com/watch?v={Id}&index=35";
        }
    }
}
