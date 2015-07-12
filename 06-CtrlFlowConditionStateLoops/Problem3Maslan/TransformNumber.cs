namespace Exam.CSharp.Maslan
{
    using System;
    using System.Numerics;

    public class NumberTransformer
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            BigInteger sumOddPositions = 0;
            BigInteger productOfSumOddPositions = 1;
            int counterTransformations = 0;
            BigInteger productOfCurrentTransformation = 0;

            while (counterTransformations < 10)
            {
                for (int i = 1; i <= input.Length; i++)
                {
                    for (int j = 0; j < input.Length - i; j++)
                    {
                        if (j % 2 != 0)
                        {
                            sumOddPositions += (char)input[j] - '0';
                        }
                    }

                    if (sumOddPositions != 0)
                    {
                        productOfSumOddPositions *= sumOddPositions;
                    }

                    sumOddPositions = 0;
                }

                productOfCurrentTransformation = productOfSumOddPositions;
                counterTransformations++;

                input = Convert.ToString(productOfSumOddPositions);

                if (input.Length == 1)
                {
                    break;
                }

                productOfSumOddPositions = 1;
            }

            if (counterTransformations < 10)
            {
                Console.WriteLine(counterTransformations);
                Console.WriteLine(productOfSumOddPositions);
            }
            else
            {
                Console.WriteLine(productOfCurrentTransformation);
            }
        }
    }
}
