using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubles.Services
{
    internal static class FacilityDistanceCalculator
    {
        private static Random random = new Random();
        public static Locations GetFacilityLocationsInfo(string facilityName)
        {
            return new Locations { name = facilityName, distanceInKm = (random.NextDouble() * 10) };
        }

        public static void GetFacilityLocationsInfov2(string facilityName, out string name, out double distance)
        {
            name = facilityName;
            distance = (random.NextDouble() * 10);


        }
    }
}
