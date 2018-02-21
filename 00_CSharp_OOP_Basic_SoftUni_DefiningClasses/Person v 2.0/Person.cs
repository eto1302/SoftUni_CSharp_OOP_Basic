using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;


public class Person
{
    private int age;
    private string name;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Person()
    {
        age = 1;
        name = "No name";
    }

    public Person(int newAge):()
    {
        name = "No name";
        age = newAge;
    }

    public Person(string newName, int newAge) : ()
    {
        name = newName;
        age = newAge;
    }
}

