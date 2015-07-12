namespace Exam.CSharpI.Money
{
    using System;
    using System.Globalization;
    using System.Threading;

    public class MoneySave
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            uint numberOfStudents = uint.Parse(Console.ReadLine());
            uint numberOfPaperSheets = uint.Parse(Console.ReadLine());
            decimal priceOfRealm = decimal.Parse(Console.ReadLine());
            decimal rezult = 0;

            rezult = numberOfStudents * numberOfPaperSheets;
            rezult = (rezult / 400) * priceOfRealm;

            Console.WriteLine("{0:0.000}", rezult);
        }
    }
}
