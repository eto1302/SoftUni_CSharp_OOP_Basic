using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Queue<Animal> animals = new Queue<Animal>();
        while (true)
        {
            string animalType = Console.ReadLine();
            if (animalType == "Beast!") break;
            string[] animalParameters = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string name = animalParameters[0];
            int age = int.Parse(animalParameters[1]);
            string gender = "";
            if (animalParameters[2] != null) gender = animalParameters[2];
            try
            {


                switch (animalType)
                {
                    case "Dog":
                        {
                            animals.Enqueue(new Dog(name, age, gender));
                            break;
                        }
                    case "Cat":
                        {
                            animals.Enqueue(new Cat(name, age, gender));
                            break;
                        }
                    case "Frog":
                        {
                            animals.Enqueue(new Frog(name, age, gender));
                            break;
                        }
                    case "Kitten":
                        {
                            animals.Enqueue(new Kitten(name, age));
                            break;
                        }
                    case "Tomcat":
                        {
                            animals.Enqueue(new Tomcat(name, age));
                            break;
                        }
                    default:
                        {
                            throw new ArgumentException("Invalid input!");
                            break;
                        }
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }
        Console.WriteLine(string.Join(Environment.NewLine,animals));
    }
}