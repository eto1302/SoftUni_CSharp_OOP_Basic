using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class Solve
    {
        public List<Product> products = new List<Product>();
        public List<Person> people = new List<Person>();

        public void AddPeople(Person member)
        {
            people.Add(member);
        }

        public void AddProducts(Product member)
        {
            products.Add(member);
        }

        public void BuyProduct(string personName, string productName)
        {
            Person person = people.Where(x => x.name == personName).First();
            Product product = products.Where(x => x.name == productName).First();
            if (person.money >= product.cost)
            {
                Console.WriteLine($"{personName} bought {productName}");
                person.money = person.money - product.cost;
                person.AddProduct(product);
            }
            else
            {
                Console.WriteLine($"{personName} can't afford {productName}");
            }
        }

        public void PrintResults()
        {
            foreach (var person in people)
            {
                if (person.products.Count > 0)
                {
                    Console.Write($"{person.name} - ");
                    for (int i = 0; i < person.products.Count-1; i++)
                    {
                        Console.Write($"{person.products[i].name}, ");
                    }
                    Console.WriteLine(person.products[person.products.Count-1].name);
                }
                else Console.WriteLine($"{person.name} - Nothing bought");

            }
        }
    }
