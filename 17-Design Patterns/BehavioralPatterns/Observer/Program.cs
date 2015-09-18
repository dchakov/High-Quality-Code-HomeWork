using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class Program
    {
        static void Main()
        {
            ICurrencyObserver niki = new NikolayObserver();
            ICurrencyObserver fxcm = new FXCMObserver();

            CurrencyPair gbpusd = new GBPUSDCurrencyPair(1.5583M);
            gbpusd.Register(niki);
            gbpusd.Register(fxcm);

            CurrencyPair eurusd = new EURUSDCurrencyPair(1.1423M);
            eurusd.Register(fxcm);

            gbpusd.Price = 1.5580M;
            gbpusd.Price = 1.5560M;
            eurusd.Price = 1.1534M;
        }
    }
}
