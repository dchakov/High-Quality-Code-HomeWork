using System.Collections.Generic;

namespace Visitor
{
    public class Car : IElementBase
    {
        private readonly List<IElementBase> parts;

        public Car()
        {
            this.parts = new List<IElementBase>
                   {
                       new Wheel("Front Left"){Tire = "Michelin Pilot Super Sport"},
                       new Wheel("Front Right"){Tire = "Michelin Pilot Super Sport"},
                       new Wheel("Back Left"){Tire = "Michelin Pilot Super Sport"},
                       new Wheel("Back Right"){Tire = "Michelin Pilot Super Sport"},
                       new Engine("3.3 TDI 225"),
                       new Body("4-door sedan"),
                       new Transmission("5-speed manual")
                   };
        }

        public void Accept(IVisitorBase visitor)
        {
            foreach (var part in this.parts)
            {
                part.Accept(visitor);
            }
        }
    }
}
