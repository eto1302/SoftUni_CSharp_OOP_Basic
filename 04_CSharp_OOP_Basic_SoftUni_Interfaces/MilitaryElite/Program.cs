using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LeutenantGeneral> leutenantGenerals = new List<LeutenantGeneral>();
            List<Engineer> engineers = new List<Engineer>();
            List<Commando> commandos = new List<Commando>();
            List<Private> privates = new List<Private>();
            List<Spy> spies = new List<Spy>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                try
                {
                    switch (tokens[0])
                    {
                        case "Private":
                            {
                                privates.Add(new Private(tokens[1], tokens[2], tokens[3], double.Parse(tokens[4])));
                                Console.WriteLine(privates.Last().ToString());
                                break;
                            }
                        case "LeutenantGeneral":
                            {
                                leutenantGenerals.Add(new LeutenantGeneral(tokens[1], tokens[2], tokens[3],
                                    double.Parse(tokens[4])));
                                Console.WriteLine(leutenantGenerals.Last().ToString());
                                for (int i = 5; i < tokens.Length; i++)
                                {
                                    Console.WriteLine($"  {privates.Where(k => k.Id == tokens[i]).First().ToString()}");
                                }
                                break;
                            }
                        case "Engineer":
                            {
                                if (tokens[5] == "Airforces" || tokens[5] == "Marines")
                                {
                                    engineers.Add(new Engineer(tokens[1], tokens[2], tokens[3], double.Parse(tokens[4]),
                                        tokens[5]));

                                    Console.WriteLine(engineers.Last().ToString());
                                    for (int i = 6; i < tokens.Length; i += 2)
                                    {
                                        Console.WriteLine($"  Part Name: {tokens[i]} Hours Worked: {tokens[i + 1]}");

                                    }
                                }
                                break;
                            }
                        case "Commando":
                            {
                                if (tokens[5] == "Airforces" || tokens[5] == "Marines")
                                {
                                    commandos.Add(new Commando(tokens[1], tokens[2], tokens[3], double.Parse(tokens[4]),
                                        tokens[5]));
                                    Console.WriteLine(commandos.Last().ToString());
                                    for (int i = 6; i < tokens.Length; i += 2)
                                    {
                                        if (tokens[i + 1] == "Finished" || tokens[i + 1] == "inProgress")
                                            Console.WriteLine($"  Code Name: {tokens[i]} State: {tokens[i + 1]}");

                                    }
                                }
                                break;

                            }
                        case "Spy":
                            {
                                spies.Add(new Spy(tokens[1], tokens[2], tokens[3], int.Parse(tokens[4])));
                                Console.WriteLine(spies.Last().ToString());
                                break;
                            }
                    }
                }
                catch (Exception exception)
                {

                }

            }
        }
    }
}
