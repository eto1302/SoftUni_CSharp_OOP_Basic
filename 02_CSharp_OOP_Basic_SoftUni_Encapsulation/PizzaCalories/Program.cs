using System;
using System.Collections.Generic;
using System.Linq;


class Program
    {
        static void Main(string[] args)
        {
           
            string input = Console.ReadLine();
            bool flag = false;
            string[] tokens = input.Split();
            string name = tokens[1];
            if (name.Length <= 15 && name.Length >= 1)
            {
                input = Console.ReadLine();
                tokens = input.Split();
                string flourType = tokens[1];
                string bakingTechnique = tokens[2];
                int weight = int.Parse(tokens[3]);
                if ((bakingTechnique.ToLower() == "crispy" || bakingTechnique.ToLower() == "chewy" ||
                     bakingTechnique.ToLower() == "homemade") &&
                    (flourType.ToLower() == "white" || flourType.ToLower() == "wholegrain") &&
                    (weight >= 1 && weight <= 200))
                {
                    Pizza pizza = new Pizza(name, new Dough(flourType, bakingTechnique, weight));
                    pizza.name = name;
                    pizza.dough = new Dough(flourType, bakingTechnique, weight);
                    pizza.dough.flourType = flourType;
                    pizza.dough.bakingTechnique = bakingTechnique;
                    pizza.dough.weight = weight;
                    input = Console.ReadLine();
                    while (input != "END")
                    {

                        tokens = input.Split();
                        pizza.AddToppings(new Toppings(tokens[1], int.Parse(tokens[2])));
                        if (pizza.toppings.Last().name != tokens[1] ||
                            pizza.toppings.Last().weight != int.Parse(tokens[2]))
                        {
                            flag = true;
                            break;
                        }
                        input = Console.ReadLine();
                    }
                    if (!flag)
                    {
                        PrintCalories(pizza);
                    }
                }
                else
                {
                    if(weight<1||weight>15) Console.WriteLine("Dough weight should be in the range [1..200].");
                    else Console.WriteLine("Invalid type of dough.");
                }
        }
            else Console.WriteLine("Pizza name should be between 1 and 15 symbols.");
        }

        public static void PrintCalories(Pizza pizza)
        {
        double calories = 0;
            double doughCalories = 0;
            double toppingsCalories = 0;
            Dough dough = pizza.dough;
            List<Toppings> toppings = pizza.toppings;
            if (dough.flourType.ToLower() == "white")
            {
                if (dough.bakingTechnique.ToLower() == "crispy") doughCalories = 2 * dough.weight * 1.5 * 0.9;
                if (dough.bakingTechnique.ToLower() == "chewy") doughCalories = 2 * dough.weight * 1.5 * 1.1;
                if (dough.bakingTechnique.ToLower() == "homemade") doughCalories = 2 * dough.weight * 1.5 * 1.0;
            }
            if (dough.flourType.ToLower() == "wholegrain")
            {
                if (dough.bakingTechnique.ToLower() == "crispy") doughCalories = 2 * dough.weight * 1.0 * 0.9;
                if (dough.bakingTechnique.ToLower() == "chewy") doughCalories = 2 * dough.weight * 1.0 * 1.1;
                if (dough.bakingTechnique.ToLower() == "homemade") doughCalories = 2 * dough.weight * 1.0 * 1.0;
            }
            foreach (var topping in toppings)
            {
                if (topping.name.ToLower() == "meat") toppingsCalories += topping.weight * 1.2;
                if (topping.name.ToLower() == "veggies") toppingsCalories += topping.weight * 0.8;
                if (topping.name.ToLower() == "cheese") toppingsCalories += topping.weight * 1.1;
                if (topping.name.ToLower() == "sauce") toppingsCalories += topping.weight * 0.9;
            }
            calories = 2 * toppingsCalories + doughCalories;
            Console.WriteLine($"{pizza.name} - {calories:f2} Calories.");
    }
    }
