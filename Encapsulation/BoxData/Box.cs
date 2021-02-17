using System;
using System.Collections.Generic;
using System.Text;

namespace BoxData
{
    public class Box
    {
        private const int SideMinimumValue = 0;
        private const string ExceptionWarning = "{0} cannot be zero or negative.";
        private double length;
        private double width;
        private double height;
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                ValidatesSide(value, nameof(this.Length));
                this.length = value;
            }
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                ValidatesSide(value, nameof(this.Width));
                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                ValidatesSide(value, nameof(this.Height));
                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            var surfaceArea = 2 * this.Width * this.Length + 2 * this.Height * this.length + 2 * this.width * this.height;
            return surfaceArea;
        }

        public double LateralSurfaceArea()
        {
            var lateralSurfaceArea = 2 * this.Width * this.Height + 2 * this.Length * this.Height;
            return lateralSurfaceArea;
        }

        public double Volume()
        {
            var volume = this.Width * this.Height * this.Length;
            return volume;
        }

        private void ValidatesSide(double value, string sideName)
        {
            if (value <= SideMinimumValue)
            {
                throw new ArgumentException(string.Format(ExceptionWarning, sideName));
            }
        }
    }
}
