using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;


    class Solve
    {
        List<Rectangle> rectangles = new List<Rectangle>();

        public void AddMember(Rectangle member)
        {
            rectangles.Add(member);
        }

        public void Intersect(string firstRectangleId, string secondRectangleId)
        {
            Rectangle secondRectangle = rectangles.Where(x => x.id == secondRectangleId).First();
            Rectangle firstRectangle = rectangles.Where(x => x.id == firstRectangleId).First();
            if(firstRectangle == null||secondRectangle == null) Console.WriteLine("false");
            else Console.WriteLine((!(secondRectangle.x > firstRectangle.x + firstRectangle.height) && !(secondRectangle.y > firstRectangle.y + firstRectangle.height)&& !(firstRectangle.x > secondRectangle.x + secondRectangle.Width) && !(firstRectangle.y > secondRectangle.y + secondRectangle.height)).ToString().ToLower());
            
        }

}

