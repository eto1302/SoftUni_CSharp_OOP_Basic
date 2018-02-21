using System;
using System.Collections.Generic;
using System.Threading;


class Program
    {
        static void Main(string[] args)
        {
            Solve cars = new Solve();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                cars.AddCars(new Car(tokens[0],decimal.Parse(tokens[1]),decimal.Parse(tokens[2]),0));
            }
            string input = Console.ReadLine();
            while (input!="End")
            {
                string[] tokens = input.Split();
                cars.Drive(tokens[1], int.Parse(tokens[2]));
                input = Console.ReadLine();
            }
            cars.PrintResults();
        }
    }
