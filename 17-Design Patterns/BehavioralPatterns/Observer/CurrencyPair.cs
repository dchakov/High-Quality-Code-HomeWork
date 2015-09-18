using System.Collections.Generic;
using System;

namespace Observer
{
    public abstract class CurrencyPair
    {
        private readonly List<ICurrencyObserver> observers = new List<ICurrencyObserver>();
        private readonly string code;
        private decimal price;

        protected CurrencyPair(string code, decimal price)
        {
            this.code = code;
            this.price = price;
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (Math.Abs(this.price - value) > 0.0001M)
                {
                    this.price = value;
                    this.Notify();
                }
            }
        }

        public string Code
        {
            get
            {
                return this.code;
            }
        }

        public void Register(ICurrencyObserver observer)
        {
            if (!this.observers.Contains(observer))
            {
                this.observers.Add(observer);
            }
        }

        public void Unregister(ICurrencyObserver observer)
        {
            if (this.observers.Contains(observer))
            {
                this.observers.Remove(observer);
            }
        }

        public void Notify()
        {
            foreach (ICurrencyObserver observer in this.observers)
            {
                observer.Notify(this);
            }
        }
    }
}
