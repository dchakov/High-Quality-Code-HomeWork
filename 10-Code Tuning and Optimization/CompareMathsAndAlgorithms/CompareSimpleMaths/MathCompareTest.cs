namespace CompareMathsAndAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    public class MathCompareTest
    {
        public static void Main()
        {
            Console.WriteLine("Compare simple Maths");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("INT");
            int integerNumber = 1;
            MeasureMathOperationTimeTester.MeasureSimpleMathExecutionTime(integerNumber);

            Console.WriteLine("LONG");
            long longNumber = 1L;
            MeasureMathOperationTimeTester.MeasureSimpleMathExecutionTime(longNumber);

            Console.WriteLine("FLOAT");
            float floatNumber = 1.0F;
            MeasureMathOperationTimeTester.MeasureSimpleMathExecutionTime(floatNumber);

            Console.WriteLine("DOUBLE");
            double doubleNumber = 1.0D;
            MeasureMathOperationTimeTester.MeasureSimpleMathExecutionTime(doubleNumber);

            Console.WriteLine("DECIMAL");
            decimal decimalNumber = 1.0M;
            MeasureMathOperationTimeTester.MeasureSimpleMathExecutionTime(decimalNumber);

            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Compare advanced Maths");
            Console.WriteLine(new string('-', 40));

            Console.WriteLine("FLOAT");
            MeasureMathOperationTimeTester.MeasureAdvanceMathExecutionTime(floatNumber);
            Console.WriteLine("DOUBLE");
            MeasureMathOperationTimeTester.MeasureAdvanceMathExecutionTime(doubleNumber);
            Console.WriteLine("DECIMAL");
            MeasureMathOperationTimeTester.MeasureAdvanceMathExecutionTime(decimalNumber);

            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Compare sort algorithms");
            Console.WriteLine(new string('-', 40));

            int[] randomInt = { 3, 6, -3, 2, 45, 23, 78, 43, 21, -735, 29 };
            int[] sortedInt = { -30, -11, 4, 6, 7, 8, 9, 13, 23, 56, 78, 90 };
            int[] reverseInt = { 100, 90, 50, 45, 23, 17, 14, 12, 6, 3, -3, -20 };

            Console.WriteLine("Random Int");
            MeasureMathOperationTimeTester.MeasureSortAlgorithmsExecutionTime(randomInt);
            Console.WriteLine("Sorted Int");
            MeasureMathOperationTimeTester.MeasureSortAlgorithmsExecutionTime(sortedInt);
            Console.WriteLine("Reversed sorted Int");
            MeasureMathOperationTimeTester.MeasureSortAlgorithmsExecutionTime(reverseInt);

            double[] randomDouble = { 4.3, 5.6, 2.3, 23.7, 7.8, 56.8, 23.5, 9.5 };
            double[] sortedDouble = { 2.3, 3.3, 4.4, 5.5, 7.7, 8.9 };
            double[] reverseDouble = { 7.3, 6.5, 5.4, 3.2, 2.1, -1.3 };

            Console.WriteLine("Random double");
            MeasureMathOperationTimeTester.MeasureSortAlgorithmsExecutionTime(randomDouble);
            Console.WriteLine("Sorted double");
            MeasureMathOperationTimeTester.MeasureSortAlgorithmsExecutionTime(sortedDouble);
            Console.WriteLine("Reversed sorted double");
            MeasureMathOperationTimeTester.MeasureSortAlgorithmsExecutionTime(reverseDouble);

            char[] randomString = "wmskrpsyio".ToCharArray();
            char[] sortedString = "acdekmo".ToCharArray();
            char[] reverseString = "zxtmkba".ToCharArray();

            Console.WriteLine("Random string");
            MeasureMathOperationTimeTester.MeasureSortAlgorithmsExecutionTime(randomString);
            Console.WriteLine("Sorted string");
            MeasureMathOperationTimeTester.MeasureSortAlgorithmsExecutionTime(sortedString);
            Console.WriteLine("Reversed sorted string");
            MeasureMathOperationTimeTester.MeasureSortAlgorithmsExecutionTime(reverseString);

            // SortingAlgorithms.InsertionSort(randomInt);
            // Console.WriteLine(string.Join(",",randomInt));
        }
    }
}
