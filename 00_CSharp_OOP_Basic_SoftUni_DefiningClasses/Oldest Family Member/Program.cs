using System;
using System.Linq;


class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] param = Console.ReadLine().Split(' ');
                int age = int.Parse(param[1]);
                string name = param[0];
                family.AddMember(new Person(name,age));
            }
            Person oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
