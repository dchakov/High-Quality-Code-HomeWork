namespace Abstraction
{
    using System;
    using System.Text;

    public class FiguresExample
    {
        public static void Main()
        {
            Circle circle = new Circle(5);
            PrintFigure(circle);

            Rectangle rect = new Rectangle(2, 3);
            PrintFigure(rect);
        }

        public static void PrintFigure(Figure figure)
        {
            string figureType = figure.GetType().Name.ToString().ToLower();
            StringBuilder result = new StringBuilder();
            result.Append("I am a ");
            result.Append(figureType);
            result.Append(string.Format(". My perimeter is {0:f2}.", figure.CalculatePerimeter()));
            result.Append(string.Format(" My surface is {0:f2}.", figure.CalculateSurface()));
            Console.WriteLine(result);
        }
    }
}
