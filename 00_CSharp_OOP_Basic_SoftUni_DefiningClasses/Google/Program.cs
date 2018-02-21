using System;
using System.Globalization;


class Program
    {
        static void Main(string[] args)
        {
           Solve people = new Solve();
           string input = Console.ReadLine();
           while (input!="End")
           {
                string[] tokens = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                if(tokens[1]=="company") people.AddCompany(tokens[0],new Company(tokens[2],tokens[3],decimal.Parse(tokens[4])));
                else if(tokens[1] == "car" ) people.AddCar(tokens[0],new Car(tokens[2],int.Parse(tokens[3])));
                else if(tokens[1] == "pokemon") people.AddPokemon(tokens[0], new Pokemon(tokens[2],tokens[3]));
                else if (tokens[1] == "parents") people.AddParent(tokens[0], new Parents(tokens[2], tokens[3]));
                else if (tokens[1] == "children") people.AddChild(tokens[0], new Children(tokens[2], tokens[3]));
               input = Console.ReadLine();
           }
            string name = Console.ReadLine();
            people.Print(name);
        }
    }
