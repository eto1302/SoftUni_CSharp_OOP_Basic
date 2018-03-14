using System;
using System.Collections.Generic;
using System.Text;

class Cat : Mammal
{
    public string breed { get; set; }

    public Cat(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight,
        foodEaten, livingRegion)
    {
        this.breed = breed;
    }

    public override string ToString()
    {
        return string.Format($"Cat [{this.name}, {this.breed}, {this.weight}, {this.livingRegion}, {this.foodEaten}]");
    }

    public void FeedCat(string[] tokens)
    {
        Console.WriteLine("Meow");
        if (tokens[0] == "Meat" || tokens[0] == "Vegetable")
        {
            this.foodEaten += int.Parse(tokens[1]);
            this.weight += int.Parse(tokens[1])*0.3;
        }
        else Console.WriteLine($"Cat does not eat {tokens[0]}!");
    }
}
