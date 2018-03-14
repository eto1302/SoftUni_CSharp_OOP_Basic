using System;
using System.Collections.Generic;
using System.Text;


class Dog : Mammal
{
    public Dog(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten,
        livingRegion)
    {
        
    }

    public override string ToString()
    {
        return string.Format($"Dog [{this.name}, {this.weight}, {this.livingRegion}, {this.foodEaten}]");
    }

    public void FeedDog(string[] tokens)
    {
        Console.WriteLine("Woof!");
        if (tokens[0] == "Meat")
        {
            this.foodEaten += int.Parse(tokens[1]);
            this.weight += int.Parse(tokens[1]) * 0.4;
        }
        else Console.WriteLine($"Dog does not eat {tokens[0]}!");
    }
}

