using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Entries> entries = new List<Entries>();
            string input = Console.ReadLine();
            while (input !="End")
            {
                string[] tokens = input.Split();
                if(tokens.Length == 2)entries.Add(new Entries(tokens[0],tokens[1]));
                else if(tokens.Length == 3) entries.Add(new Entries(tokens[0],tokens[2]));
                input = Console.ReadLine();
            }
            string number = Console.ReadLine();

            foreach (var entry in entries)
            {
                entry.Check(number);
            }

        }
    }
}