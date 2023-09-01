using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubles.Services
{
    internal class Locations
    {
        public string name { get; set; }
        public double distanceInKm { get; set; }
        public override string ToString()
        {
            return $"{name}.....{distanceInKm.ToString("F2")} km";
        }
    }
}
