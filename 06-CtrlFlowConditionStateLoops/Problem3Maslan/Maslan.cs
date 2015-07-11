using System;
using System.Numerics;
class Maslan
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        BigInteger sumOddPositions = 0;
        BigInteger productOfSumPositions = 1;
        int counttransform = 0;
        BigInteger productOnFirst = 0;
        do
        {
            for (int i = 1; i <= text.Length; i++)
            {
                for (int j = 0; j < text.Length - i; j++)
                {
                    if (j % 2 != 0)
                    {
                        sumOddPositions += (char)text[j] - '0';
                    }
                }
                if (sumOddPositions != 0)
                {
                    productOfSumPositions *= sumOddPositions;
                }
                sumOddPositions = 0;
            }
            productOnFirst = productOfSumPositions;
            counttransform++;
            
            text = Convert.ToString(productOfSumPositions);

            if (text.Length == 1)
            {
                break;
            }
            productOfSumPositions = 1;
        } while (counttransform < 10);

        if (counttransform < 10)
        {
            Console.WriteLine(counttransform);
            Console.WriteLine(productOfSumPositions);
        }
        else
        {
            Console.WriteLine(productOnFirst);
        }

    }
}
