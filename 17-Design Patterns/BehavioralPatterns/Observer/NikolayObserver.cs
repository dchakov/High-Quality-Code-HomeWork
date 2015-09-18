using System;

namespace Observer
{
    public class NikolayObserver : ICurrencyObserver
    {
        public void Notify(CurrencyPair currencyPair)
        {
            Console.WriteLine("Nikolay Notified of {0} " + "change to {1:0.0000}", currencyPair.Code, currencyPair.Price);
        }
    }
}
