namespace Builder
{
    using System;
    using System.Collections.Generic;

    public class Product
    {
        private readonly List<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Parts:");
            foreach (string part in parts)
                Console.WriteLine("\t" + part);
        }
    }
}
