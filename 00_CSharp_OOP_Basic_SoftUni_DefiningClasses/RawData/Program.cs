using System;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] args)
        {
            Solve cars = new Solve();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                List<Tire> temp = new List<Tire>();
                temp.Add(new Tire(decimal.Parse(tokens[5]), int.Parse(tokens[6])));
                temp.Add(new Tire(decimal.Parse(tokens[7]), int.Parse(tokens[8])));
                temp.Add(new Tire(decimal.Parse(tokens[9]), int.Parse(tokens[10])));
                temp.Add(new Tire(decimal.Parse(tokens[11]), int.Parse(tokens[12])));
                cars.AddCars(new Car(tokens[0]
                    ,new Engine(int.Parse(tokens[1]),int.Parse(tokens[2]))
                    ,new Cargo(int.Parse(tokens[3]),tokens[4])
                    ,new List<Tire>(temp)  ));
            }
            string type = Console.ReadLine();
            if (type == "fragile")
            {
                cars.PrintResultsFragile();
            }
            else
            {
                cars.PrintResultsFlamable();
            }
        }
    }
