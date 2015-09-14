using System;
using System.Collections.Generic;

namespace Composite
{
    public class Composite : Component
    {
        private readonly List<Component> children;

        public Composite(string name)
            : base(name)
        {
            this.children = new List<Component>();
        }

        public void AddChild(Component component)
        {
            this.children.Add(component);
        }

        public void RemoveChild(Component component)
        {
            this.children.Remove(component);
        }

        public override void Operation()
        {
            string msg = string.Format("Composite with {0}", this.children.Count);
            Console.WriteLine(msg);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
            foreach (var component in children)
            {
                component.Display(depth + 2);
            }
        }
    }
}
