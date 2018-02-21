using System;
using System.Collections.Generic;


class Program
    {
        static void Main(string[] args)
        {
            Solve trainers = new Solve();
            string input = Console.ReadLine();
            while(input!="Tournament")
            {
                string[] tokens = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                List<Pokemon> temp = new List<Pokemon>();
                temp.Add(new Pokemon(tokens[1],tokens[2],int.Parse(tokens[3])));
                trainers.AddMember(new Trainer(tokens[0],0,temp));
                input = Console.ReadLine();

            }
            input = Console.ReadLine();
            while (input!="End")
            {
                trainers.Play(input);
                input = Console.ReadLine();
            }
            trainers.PrintResults();
        }
    }
