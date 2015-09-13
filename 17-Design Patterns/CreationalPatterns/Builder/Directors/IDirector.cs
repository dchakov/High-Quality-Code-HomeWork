namespace Builder.Directors
{
    using Builders;

    public interface IDirector
    {
        void Construct(Builder builder);
    }
}
