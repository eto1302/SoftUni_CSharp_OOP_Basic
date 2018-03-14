using System;
using System.Collections.Generic;
using System.Text;

class Hen : Bird
{
    public Hen(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten, wingSize)
    {

    }

    public override string ToString()
    {
        return string.Format($"Hen [{this.name}, {this.wingSize}, {this.weight}, {this.foodEaten}]");
    }

    public void FeedHen(string[] tokens)
    {
        Console.WriteLine("Cluck");
        this.foodEaten += int.Parse(tokens[1]);
        this.weight += int.Parse(tokens[1]) * 0.35;
    }
}
