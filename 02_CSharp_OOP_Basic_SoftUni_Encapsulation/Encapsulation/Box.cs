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
            this.width = width;
            this.height = height;
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
