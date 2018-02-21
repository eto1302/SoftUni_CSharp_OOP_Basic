using System;
using System.Net.Sockets;


class Program
    {
        static void Main(string[] args)
        {
         Solve rectangles = new Solve();
            string[] parameters = Console.ReadLine().Split();
        int n = int.Parse(parameters[0]);
            int m = int.Parse(parameters[1]);
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                rectangles.AddMember(new Rectangle(tokens[0],double.Parse(tokens[1]),double.Parse(tokens[2]),double.Parse(tokens[3]),double.Parse(tokens[4])));
            }
            for (int i = 0; i < m; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                
                
                rectangles.Intersect(tokens[0],tokens[1]);
            }

        }
    }
