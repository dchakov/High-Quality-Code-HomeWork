namespace Builder.Directors
{
    using System;
    using Builders;
    public class Director : IDirector
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
