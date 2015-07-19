namespace Methods
{
    using System;

    internal class Methods
    {
        internal static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentOutOfRangeException("Sum of any two sides must be greater than third side");
            }

            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            return area;
        }

        internal static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Invalid number.Not a digit");
            }
        }

        internal static int FindMaxNumber(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("Not a valid input parameters");
            }

            int maxNumber = int.MinValue;
            for (int i = 0; i < elements.Length; i++)
            {
                maxNumber = Math.Max(maxNumber, elements[i]);
            }

            return maxNumber;
        }

        internal static void PrintAsNumber(object number, string format)
        {
            switch (format)
            {
                case "float":
                    Console.WriteLine("{0:f2}", number);
                    break;
                case "percent":
                    Console.WriteLine("{0:p0}", number);
                    break;
                case "padLeft":
                    Console.WriteLine("{0,8}", number);
                    break;
                default: throw new ArgumentException("Invalid input");
            }
        }

        internal static double CalculateDistanceBetweenTwoPoints(
            double firstPointX,
            double firstPointY,
            double secondPointX,
            double secondPointY,
            out bool isHorizontal,
            out bool isVertical)
        {
            isHorizontal = (firstPointY == secondPointY);
            isVertical = (firstPointX == secondPointX);

            double distance = Math.Sqrt(((secondPointX - firstPointX) * (secondPointX - firstPointX)) + ((secondPointY - firstPointY) * (secondPointY - firstPointY)));
            return distance;
        }

        internal static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(NumberToDigit(5));

            Console.WriteLine(FindMaxNumber(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, "float");
            PrintAsNumber(0.75, "percent");
            PrintAsNumber(2.30, "padLeft");

            bool horizontal, vertical;
            Console.WriteLine(CalculateDistanceBetweenTwoPoints(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov", "From Sofia, born at 17.03.1992");

            Student stella = new Student("Stella", "Markova", "From Vidin, gamer, high results, born at 03.11.1993");

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
