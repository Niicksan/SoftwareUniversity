using System;

namespace ClassBoxDataValidation
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double widdth, double height)
        {
            this.Length = length;
            this.Width = widdth;
            this.Height = height;
        }

        private double Length
        {
            get { return this.length; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        private double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }

        private double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                this.height = value;
            }

        }

        public string CalcullateSurfaceArea()
        {
            double surfaceArea = 2 * (length * height) + 2 * (width * height) + 2 * (length * width);

            return $"Surface Area - {surfaceArea:f2}";
        }

        public string CalcullateLataralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * (length * height) + 2 * (width * height);

            return $"Lateral Surface Area - {lateralSurfaceArea:f2}";
        }

        public string CalcullateVolume()
        {
            double volumne = length * width * height;

            return $"Volume - {volumne:f2}";
        }
    }
}