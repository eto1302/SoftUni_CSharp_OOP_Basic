using System;
using System.Collections.Generic;
using System.Text;

class Tiger : Mammal
{
    public string breed { get; set; }

    public Tiger(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight,
        foodEaten, livingRegion)
    {
        this.breed = breed;
    }

    public override string ToString()
    {
        return string.Format($"Tiger [{this.name}, {this.breed}, {this.weight}, {this.livingRegion}, {this.foodEaten}]");
    }

    public void FeedTiger(string[] tokens)
    {
        Console.WriteLine("ROAR!!!");
        if (tokens[0] == "Meat")
        {
            this.foodEaten += int.Parse(tokens[1]);
            this.weight += int.Parse(tokens[1]);
        }
        else Console.WriteLine($"Tiger does not eat {tokens[0]}!");
    }
}

