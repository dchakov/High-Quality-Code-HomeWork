using System;

namespace Facade
{
    public class CPU
    {
        public void Freeze()
        {
            Console.WriteLine("CPU is frozen");
        }

        public void Jump(long position)
        {
            Console.WriteLine("Jumping to position: {0}", position);
        }

        public void Execute()
        {
            Console.WriteLine("Executing...");
        }
    }
}
