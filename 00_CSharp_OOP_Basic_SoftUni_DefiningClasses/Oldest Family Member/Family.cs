using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class Family
    {
        public List<Person> family;

        public Family()
        {
            family = new List<Person>();
        }

        public void AddMember(Person member)
        {
            family.Add(member);
        }

        public Person GetOldestMember()
        {
            return family.OrderByDescending(p => p.Age).First();
        }
    }

