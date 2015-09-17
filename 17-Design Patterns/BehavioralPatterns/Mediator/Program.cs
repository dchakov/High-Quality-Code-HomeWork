using System;

namespace Mediator
{
    public class Program
    {
        public static void Main()
        {
            var regionalATC = new RegionalAirTrafficControl();
            var aircraft1 = new Airbus380("AI568", regionalATC);
            var aircraft2 = new Boeing747("BA157", regionalATC);
            var aircraft3 = new Airbus380("LW111", regionalATC);

            aircraft1.Altitude += 100;
            aircraft3.Altitude = 1100;

            Console.WriteLine(aircraft1.Altitude);
            Console.WriteLine(aircraft2.Altitude);
            Console.WriteLine(aircraft3.Altitude);
        }
    }
}
