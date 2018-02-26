using System;
using System.Collections.Generic;
using System.Text;


    class Person
    {
        public string name;
        public int money;
        public List<Product> products = new List<Product>();
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value)) this.name = value;
                else
                {
                    Console.WriteLine("Name cannot be empty");
                }
            }
        }
        public int Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value>=0) this.money = value;
                else
                {
                    Console.WriteLine("Money cannot be negative");
                }
            }
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public Person(string name, int money)
        {
            
            if(money <0)
            {
                Console.WriteLine("Money cannot be negative");
            }
            if (!string.IsNullOrEmpty(name) && money >= 0)
            {
                this.name = name;
                this.money = money;
            }
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty");
            }
        }
    }
