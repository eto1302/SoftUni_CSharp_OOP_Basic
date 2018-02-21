using System;
using System.Collections.Generic;
using System.Text;


    class Rectangle
    {
    public string id;

    public string Id { get => id; set => id = value; }
    

    public double width;

    public double Width { get => width; set => width = value; }

        public double height;

        public double Height { get => height; set => height = value; }

        public double x;

        public double X { get => x; set => x = value; }
        public double y;

        public double Y { get => y; set => y = value; }
        public Rectangle(string newId, double newWidth, double newHeight, double newX, double newY)
        {
            id = newId;
            width = newWidth;
            height = newHeight;
            x = newX;
            y = newY;
        }
}
