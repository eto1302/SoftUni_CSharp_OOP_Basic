using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<People> people = new List<People>();
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            string[] tokens = Console.ReadLine().Split();
            if (tokens.Length == 3)
            {
                people.Add(new People(tokens[0],int.Parse(tokens[1]),tokens[2]));
            }
            else 
                people.Add(new People(tokens[0],int.Parse(tokens[1]),tokens[2],DateTime.ParseExact(tokens[3],"dd/MM/yyyy",CultureInfo.InvariantCulture)));
        }
        string input = string.Empty;
        int food = 0;
        while ((input = Console.ReadLine())!="End")
        {
            if(people.Where(k => k.Name == input).FirstOrDefault()!=null)food += people.Where(k => k.Name == input).First().GetFood();
        }
        Console.WriteLine(food);
    }
}
