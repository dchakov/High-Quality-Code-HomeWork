namespace StatisticsPrinter
{
    using System;

    public class StatisticsPrinter
    {
        public void PrintStatistics(double[] numbers, int count)
        {
            double largestNumber = double.MinValue;
            double smallestNumber = double.MaxValue;
            double sum = 0;

            for (int i = 0; i < count; i++)
            {
                if (numbers[i] > largestNumber)
                {
                    largestNumber = numbers[i];
                }

                if (numbers[i] < smallestNumber)
                {
                    smallestNumber = numbers[i];
                }

                sum += numbers[i];
            }

            this.PrintMax(largestNumber);
            this.PrintMin(smallestNumber);

            double averageNumber = sum / count;
            this.PrintAvg(averageNumber);
        }

        private void PrintAvg(double averageNumber)
        {
            Console.WriteLine("Average number in array:{0}", averageNumber);
        }

        private void PrintMin(double smallestNumber)
        {
            Console.WriteLine("Smallest number in array:{0}", smallestNumber);
        }

        private void PrintMax(double largestNumber)
        {
            Console.WriteLine("Largest number in array:{0}", largestNumber);
        }
    }
}
