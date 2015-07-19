namespace Problem03BitMatrix
{
    using System;
    using System.Linq;
    using System.Numerics;

    internal class BitShiftMatrix
    {
        public static void Main()
        {
            int rowN = int.Parse(Console.ReadLine());
            int colM = int.Parse(Console.ReadLine());
            int moves = int.Parse(Console.ReadLine());
            int[] code = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            BigInteger[,] matrix = new BigInteger[rowN, colM];
            bool[,] boolMatrix = new bool[rowN, colM];
            double colDegree = 0;
            double rowdegree = 1;

            for (int row = rowN - 1; row >= 0; row--)
            {
                for (int col = 0; col < colM; col++)
                {
                    matrix[row, col] = (BigInteger)Math.Pow(2, colDegree);
                    colDegree++;
                }

                colDegree = rowdegree;
                rowdegree++;
            }

            int currentX = rowN - 1;
            int currentY = 0;
            BigInteger sum = 0;
            for (int i = 0; i < moves; i++)
            {
                int rowPosition = code[i] / Math.Max(rowN, colM);
                int colPosition = code[i] % Math.Max(rowN, colM);

                // Pawn move right left
                while (colPosition != currentY)
                {
                    if (!boolMatrix[currentX, currentY])
                    {
                        sum += matrix[currentX, currentY];
                        boolMatrix[currentX, currentY] = true;
                    }

                    if (colPosition >= currentY)
                    {
                        currentY++;
                    }
                    else
                    {
                        currentY--;
                    }
                }

                // Pawn move up down
                while (rowPosition != currentX)
                {
                    if (!boolMatrix[currentX, currentY])
                    {
                        sum += matrix[currentX, currentY];
                        boolMatrix[currentX, currentY] = true;
                    }

                    if (rowPosition <= currentX)
                    {
                        currentX--;
                    }
                    else
                    {
                        currentX++;
                    }
                }
            }

            if (!boolMatrix[currentX, currentY])
            {
                sum += matrix[currentX, currentY];
            }

            Console.WriteLine(sum);
        }
    }
}
