using System;
using System.Collections.Generic;
using System.Text;


    class Pokemon
    {
        public string name;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string element;
        public string Element
        {
            get => element;
            set => element = value;
        }
        public int health;
        public int Health
        {
            get => health;
            set => health = value;
        }

        public Pokemon(string newName, string newElement, int newHealth)
        {
            name = newName;
            element = newElement;
            health = newHealth;
        }

        
}

