using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method.Services
{
    internal class Pizza
    {
        public string Content { get; set; }
        public decimal TotalPrice { get; set; }

        public override string ToString()
        {
            return $"{Content} \n ------------------------ Total Price : {TotalPrice}";
        }
    }
}
