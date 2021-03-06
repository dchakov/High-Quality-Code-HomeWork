﻿namespace WalkInMatrix
{
    using System;

    internal class StartUp
    {
        internal static void Main()
        {
            Console.WriteLine("Enter a positive number: ");
            string input = Console.ReadLine();
            int n = 0;
            while (!int.TryParse(input, out n) || n < 0 || n > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            int size = int.Parse(input);
            Matrix matrix = new Matrix(size);
            Console.WriteLine(matrix);
        }
    }
}