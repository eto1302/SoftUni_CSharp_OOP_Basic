using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text;


    class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            if (length <= 0) Console.WriteLine("Length cannot be zero or negative.");
            this.width = width;
            if (width <= 0) Console.WriteLine("Width cannot be zero or negative.");
            this.height = height;
            if (height <= 0) Console.WriteLine("Height cannot be zero or negative.");

    }

    public double Length
        {
            get { return this.length; }
            set { this.length = value; }
        }
        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public bool IsPossible()
        {
            return this.length > 0 && this.width > 0 && this.height > 0;
        }
        public double GetSurfaceArea()
        {
            return 2 * ((this.length * this.width) + (this.length * this.height) + (this.width * this.height));
        }
        public double GetVolume()
        {
            return this.length * this.width * this.height;
        }
        public double GetLateralSurfaceArea()
        {
            return 2 * ((this.length * this.height) + (this.width * this.height));
        }

}
