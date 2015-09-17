using System;
using System.Collections.Generic;
using System.Linq;

namespace Mediator
{
    public class RegionalAirTrafficControl : IAirTrafficControl
    {
        private readonly List<Aircraft> registeredAircrafts = new List<Aircraft>();

        public void RegistrerAircraft(Aircraft aircraft)
        {
            if (!this.registeredAircrafts.Contains(aircraft))
            {
                this.registeredAircrafts.Add(aircraft);
            }
        }

        public void SendWarningMessage(Aircraft aircraft)
        {
            var list = from craft in this.registeredAircrafts
                       where craft != aircraft &&
                             Math.Abs(craft.Altitude - aircraft.Altitude) < 1000
                       select craft;
            foreach (var craft in list)
            {
                craft.ReceiveWarning(aircraft);
                aircraft.Climb(1000);
            }
        }
    }
}
