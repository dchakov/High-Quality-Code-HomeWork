using System;

namespace Observer
{
    public class FXCMObserver : ICurrencyObserver
    {
        public void Notify(CurrencyPair currencyPair)
        {
            Console.WriteLine("FXCM Notified of {0} " + "change to {1:0.0000}", currencyPair.Code, currencyPair.Price);
        }
    }
}
