namespace Problem02Sequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class IncreasingAbsoluteDifference
    {
        public static void Main()
        {
            int numbreOfLines = int.Parse(Console.ReadLine());
            bool[] result = new bool[numbreOfLines];

            for (int i = 0; i < numbreOfLines; i++)
            {
                string currentLine = Console.ReadLine();
                List<int> currentLineList = GetSequenceOfAbsoluteDifferensce(currentLine);
                int lenght = currentLineList.Count;
                for (int j = 1; j < lenght; j++)
                {
                    if (currentLineList[j - 1] > currentLineList[j] ||
                       (currentLineList[j] - currentLineList[j - 1]) > 1)
                    {
                        result[i] = false;
                        break;
                    }
                    else
                    {
                        result[i] = true;
                    }
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static List<int> GetSequenceOfAbsoluteDifferensce(string text)
        {
            List<int> result = new List<int>();
            int[] numbers = text.Split(' ').Select(int.Parse).ToArray();
            for (int i = 1; i < numbers.Length; i++)
            {
                result.Add(Math.Max(numbers[i - 1], numbers[i]) - Math.Min(numbers[i - 1], numbers[i]));
            }

            return result;
        }
    }
}