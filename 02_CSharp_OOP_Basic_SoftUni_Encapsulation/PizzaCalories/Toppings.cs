using System;
using System.Collections.Generic;
using System.Text;


    class Toppings
    {
        public string name;
        public int weight;

        public string Name
        {
            get
            {
                return name;
                
            }
            set
            {
                this.name = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public Toppings(string name, int weight)
        {
            if (name.ToLower() != "meat" && name.ToLower() != "veggies" && name.ToLower() != "cheese" && name.ToLower() != "sauce") Console.WriteLine($"Cannot place {name} on top of your pizza.");
            if (weight < 1 || weight > 50) Console.WriteLine($"{name} weight should be in the range [1..50].");
            if ((name.ToLower() == "meat" || name.ToLower() == "veggies" || name.ToLower() == "cheese" || name.ToLower() == "sauce") &&
                (weight >= 1 && weight <= 50))
            {
                this.name = name;
                this.weight = weight;
            }
    }
    }
