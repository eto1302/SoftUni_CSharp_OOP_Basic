using System;
using System.Collections.Generic;
using System.Text;

class Commando : ICommando
{
    private string id;
    private string firstName;
    private string lastName;
    private double salary;
    private string corps;
    private List<IMissions> missions;

    public string Id
    {
        get { return id; }
        set { this.id = value; }
    }

    public string FirstName
    {
        get { return firstName; }
        set { this.firstName = value; }

    }

    public string LastName
    {
        get { return lastName; }
        set { this.lastName = value; }

    }

    public double Salary
    {
        get { return salary; }
        set { this.salary = value; }

    }

    public string Corps
    {
        get { return corps; }
        set { this.corps = value; }

    }

   

    public Commando(string id, string firstName, string lastName, double salary, string corps)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Salary = salary;
        this.Corps = corps;
        
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"Name: {firstName} {lastName} Id: {id} Salary: {salary.ToString("F2")}")
            .AppendLine($"Corps: {corps}")
            .AppendLine("Missions:");
        
        return stringBuilder.ToString().TrimEnd();
    }
}
