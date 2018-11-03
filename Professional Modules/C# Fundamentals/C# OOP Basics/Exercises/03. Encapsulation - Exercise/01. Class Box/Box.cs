using System;

namespace ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        private double Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        private double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        private double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public void CalcullateSurfaceArea()
        {
            double area = 2 * (length * height) + 2 * (width * height) + 2 * (length * width);

            Console.WriteLine($"Surface Area - {area:f2}");
        }

        public void CalcullateLataralSurfaceArea()
        {
            double area = 2 * (length * height) + 2 * (width * height);

            Console.WriteLine($"Lateral Surface Area - {area:f2}");
        }

        public void CalcullateVolume()
        {
            double volumne = length * width * height;

            Console.WriteLine($"Volume - {volumne:f2}");
        }
    }
}