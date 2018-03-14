using System;
using System.Collections.Generic;
using System.Text;


class People : IPeople
{
    private string name;
    private string id;
    private int age;
    private DateTime birthDate;
    private string group;
    

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Id
    {
        get { return id; }
        set { id = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public DateTime BirthDate
    {
        get { return birthDate; }
        set { birthDate = value; }
    }
    public string Group
    {
        get { return this.group; }
        set { this.group = value; }
    }

    public People(string name, int age, string id, DateTime birthDate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.BirthDate = birthDate;
    }
    public People(string name, int age, string group)
    {
        this.Name = name;
        this.Age = age;
        this.Group = group;
    }

    public int GetFood()
    {
        if (string.IsNullOrWhiteSpace(this.group) || string.IsNullOrEmpty(this.group))
        {
            return 10;
        }
        return 5;
    }
}

