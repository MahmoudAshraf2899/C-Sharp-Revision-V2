using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method.Services
{
    internal static class PizzaExtensions
    {
        public static Pizza AddDough(this Pizza value, string type)
        {
            value.Content += $"{type} Dough X $4.00";
            value.TotalPrice += 4m;
            return value;
        }
        public static Pizza AddSauce(this Pizza value)
        {
            value.Content += $"Tomato Sauce X $4.00";
            value.TotalPrice += 2m;
            return value;
        }
        public static Pizza AddCheese(this Pizza value,bool extra)
        {
            value.Content += $"{(extra?"Extra" : "Regular")}Cheese Sauce X $4.00";
            value.TotalPrice += 2m;
            return value;
        }
    }
}
