using System;

class Program
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        string concantenateNumber = "";
        int counterZeros = 0;
        int counterOnes = 0;
        int rezultZeroes = 0;
        int rezultOnes = 0;

        for (int i = 0; i < numberN; i++)
        {
            concantenateNumber += Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(30, '0');
        }
        for (int i = 0; i < concantenateNumber.Length; i++)
        {
            if ((char)concantenateNumber[i] == 49)
            {
                counterOnes++;
                rezultOnes = Math.Max(counterOnes, rezultOnes);
                counterZeros = 0;
            }
            else
            {
                counterZeros++;
                rezultZeroes = Math.Max(counterZeros, rezultZeroes);
                counterOnes = 0;
            }
        }
        Console.WriteLine(rezultOnes);
        Console.WriteLine(rezultZeroes);
    }
}
