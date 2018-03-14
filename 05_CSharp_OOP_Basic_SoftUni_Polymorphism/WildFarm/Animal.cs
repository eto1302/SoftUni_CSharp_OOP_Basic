using System;
using System.Collections.Generic;
using System.Text;

class Animal
{
    protected string name { get; set; }
    protected double weight { get; set; }
    protected int foodEaten { get; set; }

    public Animal(string name, double weight, int foodEaten)
    {
        this.name = name;
        this.weight = weight;
        this.foodEaten = foodEaten;
    }
}

