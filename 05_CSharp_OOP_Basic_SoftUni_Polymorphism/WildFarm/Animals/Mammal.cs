using System;
using System.Collections.Generic;
using System.Text;

class Mammal : Animal
{
    public string livingRegion { get; set; }
    public Mammal(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten)
    {
        this.livingRegion = livingRegion;
    }
}
