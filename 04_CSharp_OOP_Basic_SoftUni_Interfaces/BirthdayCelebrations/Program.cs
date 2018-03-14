using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.PortableExecutable;


class Program
{
    static void Main(string[] args)
    {
        List<Entries> entries = new List<Entries>();
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] tokens = input.Split();
            switch (tokens[0])
            {
                case "Citizen":
                    {
                        entries.Add(new Entries(tokens[0], tokens[1], tokens[3], DateTime.ParseExact(tokens[4], "dd/MM/yyyy", CultureInfo.InvariantCulture)));
                        break;
                    }
                case "Pet":
                    {
                        entries.Add(new Entries(tokens[0], tokens[1], null, DateTime.ParseExact(tokens[2], "dd/MM/yyyy", CultureInfo.InvariantCulture)));
                        break;
                    }
                case "Robot":
                    {
                        entries.Add(new Entries(tokens[0], tokens[1], tokens[2], DateTime.Now));
                        break;
                    }
            }
        }
        int year = int.Parse(Console.ReadLine());
        foreach (var entry in entries)
        {
            entry.PrintResults(year);
        }
    }
}
