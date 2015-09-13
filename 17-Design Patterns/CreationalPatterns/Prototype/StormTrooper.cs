namespace Prototype
{
    using System;

    public abstract class StormTrooper : ICloneable
    {
        public int FirePower { get; set; }
        public int Armor { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
