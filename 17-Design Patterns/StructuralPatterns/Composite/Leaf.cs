using System;

namespace Composite
{
    public class Leaf:Component
    {
        public Leaf(string name)
            : base(name)
        {
        }
        
        public override void Operation()
        {
            Console.WriteLine("Leaf.");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
