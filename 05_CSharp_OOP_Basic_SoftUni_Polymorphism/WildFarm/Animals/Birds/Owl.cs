using System;
using System.Collections.Generic;
using System.Text;

class Owl : Bird
{
    public Owl(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten, wingSize)
    {

    }

    public override string ToString()
    {
        return string.Format($"Owl [{this.name}, {this.wingSize}, {this.weight}, {this.foodEaten}]");
    }

    public void FeedOwl(string[] tokens)
    {
        Console.WriteLine("Hoot Hoot");
        if (tokens[0] == "Meat")
        {
            this.foodEaten += int.Parse(tokens[1]);
            this.weight += int.Parse(tokens[1]) * 0.25;
        }
        else Console.WriteLine($"Owl does not eat {tokens[0]}!");
    }
}
