namespace Composite
{
    public abstract class Component
    {
        protected readonly string name;

        protected Component(string name)
        {
            this.name = name;
        }

        public abstract void Operation();
        public abstract void Display(int depth);
    }
}
