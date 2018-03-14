using System;
using System.Collections.Generic;
using System.Text;

class Bird : Animal
{
    protected double wingSize { get; set; }

    public Bird(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten)
    {
        this.wingSize = wingSize;
    }

    public override string ToString()
    {
        return string.Format($"Bird [{this.name}, {this.wingSize}, {this.weight}, {this.foodEaten}]");
    }
}
