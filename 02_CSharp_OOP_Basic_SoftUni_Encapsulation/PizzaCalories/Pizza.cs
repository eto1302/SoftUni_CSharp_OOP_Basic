using System;
using System.Collections.Generic;
using System.Text;

    class Pizza
    {
        public string name;
        public Dough dough;
        public List<Toppings> toppings = new List<Toppings>();
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
        public Dough Dough
        {
            get
            {
                return dough;
            }
            set
            {
                this.dough = value;
            }
        }

        public void AddToppings(Toppings member)
        {
            if(toppings.Count<=10)toppings.Add(member);
            else Console.WriteLine("Number of toppings should be in range [0..10].");
        }
        public Pizza(string name,Dough dough)
        {
        
            if ((dough.bakingTechnique.ToLower() == "crispy" || dough.bakingTechnique.ToLower() == "chewy" || dough.bakingTechnique.ToLower() == "homemade") &&
                (dough.flourType.ToLower() == "white" || dough.flourType.ToLower() == "wholegrain") &&
                (dough.weight >= 1 && dough.weight <= 200))
            {
                if (name.Length < 1 || name.Length > 15)
                    Console.WriteLine("Pizza name should be between 1 and 15 symbols.");
                else
                {
                    this.name = name;
                    this.dough = dough;
                }
            }
        }

        
    }

