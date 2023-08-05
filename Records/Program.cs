using System;

namespace Records
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(1, 2);
            var p2 = new Point(1, 2);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine($"p1.equals p2 :{p1.Equals(p2)}");
            Console.WriteLine($"p1 == p2 :{p1 == p2}");

            Console.ReadKey();
        }
        record Point
        {

            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
