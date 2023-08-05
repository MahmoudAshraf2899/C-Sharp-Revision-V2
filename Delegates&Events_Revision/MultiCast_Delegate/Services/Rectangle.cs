using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCast_Delegate.Services
{
    public class RectangleHelper
    {
        public delegate void rectangleDelegate(decimal width, decimal height);

        public void GetArea(decimal width, decimal height)
        {
            var result = width * height;
            Console.WriteLine($"Area is : {result}");
        }
        public void GetPerimeter(decimal width, decimal height)
        {
            var result = 2 * (width + height);
            Console.WriteLine($"Perimeter is : {result}");
        }
    }
}
