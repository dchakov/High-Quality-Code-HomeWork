namespace VariablesDataExpression
{
    using System;

    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.height = value;
            }
        }

        public static Size GetRotatedSize(Size size, double angleOfTheFiguretoBeRotaed)
        {
            double cosinusWidth = Math.Abs(Math.Cos(angleOfTheFiguretoBeRotaed));
            double sinusWidth = Math.Abs(Math.Sin(angleOfTheFiguretoBeRotaed));
            double cosinusHeight = Math.Abs(Math.Cos(angleOfTheFiguretoBeRotaed));
            double sinusHeight = Math.Abs(Math.Sin(angleOfTheFiguretoBeRotaed));

            double figureWidth = (cosinusWidth * size.width) + (sinusHeight * size.height);
            double figureHeight = (sinusWidth * size.width) + (cosinusHeight * size.height);

            Size result = new Size(figureWidth, figureHeight);

            return result;
        }
    }
}
