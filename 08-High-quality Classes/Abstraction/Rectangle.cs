namespace Abstraction
{
    using System;

    public class Rectangle : Figure, IFigure
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
            : base()
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
                if (value <= 0.0)
                {
                    throw new ArgumentException("Width cannot be zero or negative");
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
                if (value <= 0.0)
                {
                    throw new ArgumentException("Height cannot be zero or negative");
                }

                this.height = value;
            }
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
