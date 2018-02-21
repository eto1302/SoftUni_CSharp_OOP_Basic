using System;
using System.Text.RegularExpressions;


class Program
    {
        static void Main(string[] args)
        {
            
            Solve elements = new Solve();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if(tokens.Length == 4)elements.AddEngine(new Engine(tokens[0],int.Parse(tokens[1]),int.Parse(tokens[2]),tokens[3]));
                else
                {
                    if(tokens.Length == 2) elements.AddEngine(new Engine(tokens[0],int.Parse(tokens[1]),null,null));
                    else if (tokens.Length == 3)
                    {
                        if (Regex.IsMatch(tokens[2], @"[0-9]+"))
                        {
                            elements.AddEngine(new Engine(tokens[0], int.Parse(tokens[1]), int.Parse(tokens[2]), null));
                        }
                        else
                        {
                            elements.AddEngine(new Engine(tokens[0],int.Parse(tokens[1]),null, tokens[2]));
                        }
                    }
                }
            }
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] tokens = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 4) elements.AddCar(new Car(tokens[0], tokens[1], int.Parse(tokens[2]), tokens[3]));
                else
                {
                if (tokens.Length == 2) elements.AddCar(new Car(tokens[0], tokens[1], null, null));
                    else if (tokens.Length == 3)
                    {
                    if (Regex.IsMatch(tokens[2], @"[0-9]+"))
                    {
                        elements.AddCar(new Car(tokens[0], tokens[1], int.Parse(tokens[2]), null));
                    }
                    else
                    {
                        elements.AddCar(new Car(tokens[0], tokens[1], null, tokens[2]));
                    }
                    }
                }
            }
            elements.PrintResults();
        }
    }
