namespace Task01.Chef
{
    public class Vegetable
    {
        public Vegetable()
        {
            this.IsPeeled = false;
            this.IsRotten = false;
        }

        public bool IsPeeled { get; set; }

        public bool IsRotten { get; set; }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
