using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class Solve
    {
        public List<Person> people;

        public Solve()
        {
            people = new List<Person>();
        }

        public void AddPeople(Person member)
        {
            people.Add(member);
        }

        public Person[] GetResult()
        {
            return people.Where(p => p.Age>30).OrderBy(p => p.Name).ToArray();
        }
    }

