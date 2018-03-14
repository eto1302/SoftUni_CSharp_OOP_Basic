using System;
using System.Collections.Generic;
using System.Text;

class Mouse : Mammal
{
    public Mouse(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten,
        livingRegion)
    {
        
    }

    public override string ToString()
    {
        return string.Format($"Mouse [{this.name}, {this.weight}, {this.livingRegion}, {this.foodEaten}]");
    }

    public void FeedMouse(string[] tokens)
    {
        Console.WriteLine("Squeak");
        if (tokens[0] == "Vegetable" || tokens[0] == "Fruit")
        {
            this.foodEaten += int.Parse(tokens[1]);
            this.weight += int.Parse(tokens[1]) * 0.1;
        }
        else Console.WriteLine($"Mouse does not eat {tokens[0]}!");
    }
}
