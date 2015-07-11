using System;
using System.Threading;
using System.Globalization;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        uint numberNOfStudents = uint.Parse(Console.ReadLine());
        uint numberSOfPaperSheets = uint.Parse(Console.ReadLine());
        double pricePOfRealm = double.Parse(Console.ReadLine());
        double rezult = 0;

        rezult = numberNOfStudents*numberSOfPaperSheets;
        rezult = (rezult / 400)*pricePOfRealm;

        Console.WriteLine("{0:0.000}",rezult);

    }
}
