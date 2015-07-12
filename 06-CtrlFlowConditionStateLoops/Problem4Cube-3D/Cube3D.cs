namespace Exam.CSharp.Cube3D
{
    using System;

    public class Cube3D
    {
        public static void Main()
        {
            int sideSize = int.Parse(Console.ReadLine());

            // First row
            PrintRow(sideSize - 1, ":", true);

            // First half
            for (int row = 0; row < sideSize - 2; row++)
            {
                Console.Write(":");
                PrintRow(sideSize - 2, " ", false);
                PrintRow(row, "|", true);
            }

            // Middle part
            PrintRow(sideSize - 1, ":", false);
            PrintRow(sideSize - 2, "|", true);

            // Second half
            for (int row = 0; row < sideSize - 2; row++)
            {
                PrintRow(1 + row, " ", false);
                PrintRow(sideSize - 2, "-", false);
                PrintRow(sideSize - 3 - row, "|", true);
            }

            // Last row
            PrintRow(sideSize - 1, " ", false);
            PrintRow(sideSize - 2, ":", true);
        }

        public static void PrintRow(int length, string symbol, bool endLine)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(symbol);
            }

            if (endLine)
            {
                Console.WriteLine(":");
            }
            else
            {
                Console.Write(":");
            }
        }
    }
}
