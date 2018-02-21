using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

    class Solve
    {
    List<Person> people = new List<Person>();

        public void AddCompany(string name, Company company)
        {
            if (people.Where(p => p.name == name).FirstOrDefault() == null)
                people.Add(new Person(name, company, null, null, null, null));
            else people.Where(p => p.name == name).FirstOrDefault().company = company;
        }
        public void AddPokemon(string name, Pokemon pokemon)
        {
            List<Pokemon> temp = new List<Pokemon>();
            temp.Add(pokemon);
            if (people.Where(p => p.name == name).FirstOrDefault() == null)
                people.Add(new Person(name, null, temp, null, null, null));
        else
            {
                List<Pokemon> par = people.Where(p => p.name == name).First().pokemon;
                if (par == null) par = new List<Pokemon>();
                people.Where(p => p.name == name).First().pokemon = par;
                people.Where(p => p.name == name).First().pokemon.Add(pokemon);
            }
    }
        public void AddParent(string name, Parents parent)
        {
            List<Parents> temp = new List<Parents>();
            temp.Add(parent);
            if (people.Where(p => p.name == name).FirstOrDefault() == null)
                people.Add(new Person(name, null, null, temp, null, null));
            else
            {
                List<Parents> par = people.Where(p => p.name == name).First().parents;
                if(par == null) par = new List<Parents>();
                people.Where(p => p.name == name).First().parents  = par;
                people.Where(p => p.name == name).First().parents.Add(parent);
            }
        }
        public void AddChild(string name, Children child)
         {
        List<Children> temp = new List<Children>();
        temp.Add(child);
        if (people.Where(p => p.name == name).FirstOrDefault() == null)
            people.Add(new Person(name, null, null, null, temp, null));
        else
        {
            List<Children> par = people.Where(p => p.name == name).First().children;
            if (par == null) par = new List<Children>();
            people.Where(p => p.name == name).First().children = par;
            people.Where(p => p.name == name).First().children.Add(child);
        }
    }
        public void AddCar(string name, Car car)
        {
            if (people.Where(p => p.name == name).FirstOrDefault() == null)
                people.Add(new Person(name, null, null, null, null, car));
            else people.Where(p => p.name == name).FirstOrDefault().car = car;
        }

        public void Print(string name)
        {
            Person person = people.Where(p => p.name == name).First();
            Console.WriteLine(name);
            Console.WriteLine($"Company:");
            if (person.company != null) Console.WriteLine($"{person.company.name} {person.company.department} {person.company.salary:f2}");
            Console.WriteLine("Car:");
            if (person.car != null) Console.WriteLine($"{person.car.carModel} {person.car.carSpeed}");
            Console.WriteLine("Pokemon:");
            if(person.pokemon!=null)foreach (var pokemon in person.pokemon)
            {
                Console.WriteLine($"{pokemon.name} {pokemon.type}");
            }
            Console.WriteLine("Parents:");
            if(person.parents!=null)foreach (var parent in person.parents)
            {
                Console.WriteLine($"{parent.name} {parent.birthday}");
            }
            Console.WriteLine("Children:");
            if(person.children != null)foreach (var children in person.children)
            {
                Console.WriteLine($"{children.name} {children.birthday}");
            }
    }
}
