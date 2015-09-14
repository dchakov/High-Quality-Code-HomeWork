using System;
using System.Threading;

namespace Facade
{
    public class Memory
    {
        public void Load(byte[] data)
        {
            Console.WriteLine("Loading data: ");
            foreach (var b in data)
            {
                Console.Write(b + " ");
                Thread.Sleep(700);
            }

            Console.WriteLine("\nLoading compleded");
        }
    }
}
