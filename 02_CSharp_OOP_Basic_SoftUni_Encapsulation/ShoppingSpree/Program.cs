using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Solve people = new Solve();
            string input = Console.ReadLine();
            bool flag = false;
            string[] tokens = input.Split(new[] { ';' });
            for (int i = 0; i < tokens.Length; i++)
            {
                string[] parameters = tokens[i].Split('=');
                int money = int.Parse(parameters[1]);
                string name = parameters[0];
                if((!string.IsNullOrEmpty(name)&&(!string.IsNullOrWhiteSpace(name))) && money >= 0)people.AddPeople(new Person(name, money));
                if (string.IsNullOrEmpty(name) || money < 0||string.IsNullOrWhiteSpace(name))
                {
                    flag = true;
                    
                }
                if(money<0) Console.WriteLine("Money cannot be negative");
                if(string.IsNullOrEmpty(name)||string.IsNullOrWhiteSpace(name)) Console.WriteLine("Name cannot be empty");
                if (flag) break;
            }
            if (!flag)
            {
                input = Console.ReadLine();
                tokens = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < tokens.Length; i++)
                {
                    string[] parameters = tokens[i].Split('=');
                    int cost = int.Parse(parameters[1]);
                    string name = parameters[0];
                    if((!string.IsNullOrEmpty(name))&&cost>=0&&!string.IsNullOrWhiteSpace(name))people.AddProducts(new Product(name, cost));
                    if (string.IsNullOrEmpty(name) || cost < 0||string.IsNullOrWhiteSpace(name))
                    {
                        flag = true;
                       
                    }
                    if (cost < 0) Console.WriteLine("Money cannot be negative");
                    if (string.IsNullOrEmpty(name)||string.IsNullOrWhiteSpace(name)) Console.WriteLine("Name cannot be empty");
                    if (flag) break;
                }

                if (!flag)
                {
                    input = Console.ReadLine();
                    while (input != "END")
                    {
                        tokens = input.Split();
                        string personName = tokens[0];
                        string productName = tokens[1];
                        people.BuyProduct(personName,productName);
                        input = Console.ReadLine();
                    }
                    people.PrintResults();
                }
            }
        }
    }