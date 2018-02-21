using System;
using System.Collections.Generic;
using System.Text;


    class Person
    {
        public string name;

        public string Name
        {
            get => name;
            set => name = value;
        }
        public Company company;

        public Company Company
        {
            get => company;
            set => company = value;
        }
        public List<Pokemon> pokemon;

        public List<Pokemon> Pokemon
        {
            get => pokemon;
            set => pokemon = value;
        }
        public List<Parents> parents;

        public List<Parents> Parents
        {
            get => parents;
            set => parents = value;
        }
        public List<Children> children;

        public List<Children> Children
        {
            get => children;
            set => children = value;
        }
        public Car car;

        public Car Car
        {
            get => car;
            set => car = value;
        }

        public Person(string newName, Company newCompany, List<Pokemon> newPokemons, List<Parents> newParents, List<Children> newChildren, Car newCar)
        {
            name = newName;
            company = newCompany;
            pokemon = newPokemons;
            parents = newParents;
            children = newChildren;
            car = newCar;
        }

}
