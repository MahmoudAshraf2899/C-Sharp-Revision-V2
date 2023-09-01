using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubles.Services
{
    public static class FacilityDistanceCalculatorUsingTuples
    {
        private static Random random = new Random();
        public static Tuple<int,string> CalculateFicilityDistance(string facilityName)
        {
            return Tuple.Create(1, facilityName);
        }
    }
}
