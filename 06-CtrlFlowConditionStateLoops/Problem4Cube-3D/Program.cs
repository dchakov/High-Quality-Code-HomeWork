using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        for (int row = 0; row < number; row++)      // 1 row
        {
            Console.Write(":");
        }
        Console.WriteLine();

        for (int mid = 0; mid < number - 2; mid++)
        {
            Console.Write(":");                         
            for (int i = 0; i < number - 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write(":");

            for (int i = 0; i < mid; i++)
            {
                Console.Write("|");
            }
            Console.Write(":");
            Console.WriteLine();
        }
        for (int i = 0; i < number; i++)
        {
            Console.Write(":");
        }
        for (int i = 0; i < number -2 ; i++)
        {
            Console.Write("|");
        }
        Console.Write(":");
        Console.WriteLine();

        for (int mid = 0; mid < number - 2; mid++)
        {
            for (int i = 0; i < 1 + mid; i++)
            {
                Console.Write(" ");
            }
            Console.Write(":");

            for (int i = 0; i < number - 2; i++)
            {
                Console.Write("-");
            }
            Console.Write(":");
            for (int i = 0; i < number-3-mid; i++)
            {
              Console.Write("|");  
            }
            Console.Write(":");
            
            Console.WriteLine();
        }
        for (int i = 0; i < number -1; i++)
        {
            Console.Write(" ");
        }            
        for (int i = 0; i < number; i++)
        {
            Console.Write(":");
        }
        Console.WriteLine();
       
    }
}