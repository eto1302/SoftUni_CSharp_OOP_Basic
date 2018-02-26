using System;
using System.Collections.Generic;
using System.Text;

    class Product
    {
        public string name;
        public int cost;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                 this.name = value;
                
            }
        }
        public int Cost
        {
            get
            {
                return this.cost;
            }
            set
            {
               this.cost = value;
                
            }
        }

        public Product(string name, int age)
        {
            
            
            if (!string.IsNullOrEmpty(name) && age >= 0)
            {
                this.name = name;
                this.cost = age;
            }
            
        }
}
