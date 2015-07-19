namespace Problem05CatSongs
{
    using System;

    public class MinimumSongs
    {
        public static void Main()
        {
            string[] catsN = Console.ReadLine().Split(' ');
            byte numberCats = byte.Parse(catsN[0]);
            string[] songsN = Console.ReadLine().Split(' ');
            byte numberSongs = byte.Parse(songsN[0]);
            int[,] matrixOnes = new int[numberSongs + 1, numberCats + 1];

            string lines = Console.ReadLine();
            while (lines != "Mew!")
            {
                string[] numberCatsSongs = lines.Split(' ');
                matrixOnes[int.Parse(numberCatsSongs[4]), int.Parse(numberCatsSongs[1])] = 1;
                lines = Console.ReadLine();
            }

            int[,] matrix = new int[numberSongs + 1, numberCats + 1];
            PrintMatrix(matrixOnes, numberSongs, numberCats);

            int counter = 0;
            int result = 0;
            int rowCounter = 0;
            for (int i = 1; i <= numberSongs; i++)
            {
                for (int j = 1; j <= numberCats; j++)
                {
                    matrix[i, j] = matrixOnes[i, j] | matrixOnes[i - 1, j];
                    matrixOnes[i, j] = matrix[i, j];
                    if (matrixOnes[i, j] == 1)
                    {
                        counter++;
                    }
                }

                if (rowCounter < counter)
                {
                    rowCounter = counter;
                    result++;
                }

                if (counter == numberCats)
                {
                    break;
                }

                counter = 0;
            }

            if (counter < numberCats)
            {
                Console.WriteLine("No concert!");
            }
            else
            {
                Console.WriteLine(result);
            }
        }

        public static void PrintMatrix(int[,] matrix, int numberSongs, int numberCats)
        {
            for (int i = 0; i <= numberSongs; i++)
            {
                for (int j = 0; j <= numberCats; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}