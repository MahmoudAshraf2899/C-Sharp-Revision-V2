
using Inheritance.Services;
using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eagle eagle = new Eagle();
            eagle.Move();

            var e = new Eagle();
            Animal a = e;
        }
    }
}
