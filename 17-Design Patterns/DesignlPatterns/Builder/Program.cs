namespace Builder
{
    using System;
    using Builders;
    using Directors;
    public static class Program
    {
        static void Main()
        {
            Builder b1 = new ConcreteBuilder1();
            Director director = new Director();

            director.Construct(b1);
            var p1 = b1.GetResult();
            p1.Show();
        }
    }
}
