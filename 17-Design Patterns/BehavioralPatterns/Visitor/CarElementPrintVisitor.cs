using System;

namespace Visitor
{
    public class CarElementPrintVisitor : IVisitorBase
    {
        public void Visit(Wheel wheel)
        {
            Console.WriteLine("Wheel ({0}): {1}", wheel.Name, wheel.Tire);
        }

        public void Visit(Body body)
        {
            Console.WriteLine("Body: {0}", body.Name);
        }

        public void Visit(Engine engine)
        {
            Console.WriteLine("Engine: {0}", engine.Name);
        }

        public void Visit(Transmission transmission)
        {
            Console.WriteLine("Transmission: {0}", transmission.Name);
        }
    }
}
