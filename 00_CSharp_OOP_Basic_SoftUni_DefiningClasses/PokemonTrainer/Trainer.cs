using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;


    class Trainer
    {
        public string name;
        public string Name
        {
        get => name;
        set => name = value;
        }
        public int badges;
        public int Badges
        {
            get => badges;
            set => badges = value;
        }
        public List<Pokemon> pokemon;
        public List<Pokemon> Pokemon
        {
            get => pokemon;
            set => pokemon = value;
        }

        public Trainer(string newName, int newBadges, List<Pokemon> newPokemon)
        {
            name = newName;
            badges = newBadges;
            pokemon = newPokemon;
        }

}

