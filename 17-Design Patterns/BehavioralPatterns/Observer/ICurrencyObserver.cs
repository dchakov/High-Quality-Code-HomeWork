
namespace Observer
{
    public interface ICurrencyObserver
    {
        void Notify(CurrencyPair currencyPair);
    }
}
