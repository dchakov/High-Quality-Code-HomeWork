namespace Exam.CSharpI.SequenceOfBits
{
    using System;

    public class BitsConcatenation
    {
        public static void Main()
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            string concantenatedNumbers = string.Empty;
            int counterZeros = 0;
            int counterOnes = 0;
            int rezultZeroes = 0;
            int rezultOnes = 0;

            for (int i = 0; i < numberOfRows; i++)
            {
                concantenatedNumbers += Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(30, '0');
            }

            for (int i = 0; i < concantenatedNumbers.Length; i++)
            {
                if ((char)concantenatedNumbers[i] == 49)
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
}