using System;


    class Program
    {
        static void Main(string[] args)
        {
            Solve people = new Solve();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                people.AddPeople(new Person(tokens[0],int.Parse(tokens[1])));
            }
            foreach (var person in people.GetResult())
            {
                
                    Console.WriteLine($"{person.Name} - {person.Age}");
                
            }
        }
    }
