namespace CompareMathsAndAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    public class MeasureMathOperationTimeTester
    {
        private const int NumberOfLoops = 100000;

        public static void ExecutionTime(Action action)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int times = 0; times < NumberOfLoops; times++)
            {
                action();
            }

            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);
        }

        public static void MeasureSimpleMathExecutionTime(dynamic number)
        {
            dynamic result = 0;

            Console.Write("Addition: ".PadRight(20));
            ExecutionTime(() => result += number);

            Console.Write("Subtraction: ".PadRight(20));
            ExecutionTime(() => result -= number);

            Console.Write("Incremention: ".PadRight(20));
            ExecutionTime(() => result++);

            Console.Write("Multiplication: ".PadRight(20));
            ExecutionTime(() => result *= number);

            Console.Write("Division: ".PadRight(20));
            ExecutionTime(() => result /= number);
        }

        public static void MeasureAdvanceMathExecutionTime(dynamic number)
        {
            dynamic result = 0;

            Console.Write("Square root: ".PadRight(20));
            ExecutionTime(() => result = Math.Sqrt((double)number));

            Console.Write("Natural logarithm: ".PadRight(20));
            ExecutionTime(() => result = Math.Log((double)number));

            Console.Write("Sinus: ".PadRight(20));
            ExecutionTime(() => result = Math.Sin((double)number));
        }

        public static void MeasureSortAlgorithmsExecutionTime<T>(T[] collection) where T : IComparable
        {
            Console.Write("Insertion sort: ".PadRight(20));
            ExecutionTime(() => SortingAlgorithms.InsertionSort(collection));

            Console.Write("Selection sort: ".PadRight(20));
            ExecutionTime(() => SortingAlgorithms.SelectionSort(collection));

            Console.Write("Quick sort: ".PadRight(20));
            ExecutionTime(() => SortingAlgorithms.QuickSort(collection, 0, collection.Length - 1));
        }
    }
}
