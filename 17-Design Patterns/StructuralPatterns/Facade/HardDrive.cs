using System;

namespace Facade
{
    public class HardDrive
    {
        public byte[] Read(int size)
        {
            var bytes = new byte[size];
            var random = new Random();
            random.NextBytes(bytes);
            return bytes;
        }
    }
}
