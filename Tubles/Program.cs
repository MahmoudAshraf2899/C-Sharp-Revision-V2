using Tubles.Services;

var info =FacilityDistanceCalculator.GetFacilityLocationsInfo("Hospital");
Console.WriteLine($"{info} v1");

string name = "";
double distanceInKM = 0;
FacilityDistanceCalculator.GetFacilityLocationsInfov2("Hospital",out name,out distanceInKM);
Console.WriteLine($"{name}.....{distanceInKM.ToString("F2")} km for v2");
Console.WriteLine("---------Tuples-----------");

Console.ReadKey();