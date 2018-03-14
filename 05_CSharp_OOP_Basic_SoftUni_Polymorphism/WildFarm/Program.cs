using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Cat> cats = new List<Cat>();
        List<Dog> dogs = new List<Dog>();
        List<Hen> hens = new List<Hen>();
        List<Owl> owls = new List<Owl>();
        List<Mouse> mice = new List<Mouse>();
        List<Tiger> tigers = new List<Tiger>();
        string input = string.Empty;
        List<string> order = new List<string>();
        while (true)
        {
            string firstLine = Console.ReadLine();
            if (firstLine == "End") break;
            string secondLine = Console.ReadLine();

            string[] firstLineTokens = firstLine.Split();
            string[] secondLineTokens = secondLine.Split();

            switch (firstLineTokens[0])
            {
                case "Cat":
                    {
                        cats.Add(new Cat(firstLineTokens[1], double.Parse(firstLineTokens[2]), 0, firstLineTokens[3], firstLineTokens[4]));
                        cats.Last().FeedCat(secondLineTokens);
                        order.Add("Cat");
                        break;
                    }
                case "Dog":
                    {
                        dogs.Add(new Dog(firstLineTokens[1], double.Parse(firstLineTokens[2]), 0, firstLineTokens[3]));
                        dogs.Last().FeedDog(secondLineTokens);
                        order.Add("Dog");
                        break;
                    }
                case "Hen":
                    {
                        hens.Add(new Hen(firstLineTokens[1], double.Parse(firstLineTokens[2]), 0, double.Parse(firstLineTokens[3])));
                        hens.Last().FeedHen(secondLineTokens);
                        order.Add("Hen");
                        break;
                    }
                case "Owl":
                    {
                        owls.Add(new Owl(firstLineTokens[1], double.Parse(firstLineTokens[2]), 0, double.Parse(firstLineTokens[3])));
                        owls.Last().FeedOwl(secondLineTokens);
                        order.Add("Owl");
                        break;
                    }
                case "Mouse":
                    {
                        mice.Add(new Mouse(firstLineTokens[1], double.Parse(firstLineTokens[2]), 0, firstLineTokens[3]));
                        mice.Last().FeedMouse(secondLineTokens);
                        order.Add("Mouse");
                        break;
                    }
                case "Tiger":
                    {
                        tigers.Add(new Tiger(firstLineTokens[1], double.Parse(firstLineTokens[2]), 0, firstLineTokens[3], firstLineTokens[4]));
                        tigers.Last().FeedTiger(secondLineTokens);
                        order.Add("Tiger");
                        break;
                    }
            }
        }
        int[] counts = new int[6];
        for (int i = 0; i < order.Count; i++)
        {
            switch (order[i])
            {
                case "Cat":
                    {
                        
                        Console.WriteLine(cats[counts[0]].ToString());
                        counts[0]++;
                        break;
                    }
                case "Dog":
                    {
                        
                        Console.WriteLine(dogs[counts[1]].ToString());
                        counts[1]++;
                        break;
                    }
                case "Hen":
                    {
                        
                        Console.WriteLine(hens[counts[2]].ToString());
                        counts[2]++;
                        break;
                    }
                case "Owl":
                    {
                        
                        Console.WriteLine(owls[counts[3]].ToString());
                        counts[3]++;
                        break;
                    }
                case "Mouse":
                    {
                        
                        Console.WriteLine(mice[counts[4]].ToString());
                        counts[4]++;
                        break;
                    }
                case "Tiger":
                    {
                        
                        Console.WriteLine(tigers[counts[5]].ToString());
                        counts[5]++;
                        break;
                    }
            }
        }
    }
}