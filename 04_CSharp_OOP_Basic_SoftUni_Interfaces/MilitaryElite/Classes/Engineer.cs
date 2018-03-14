using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

class Engineer : IEngineer
{
    

    private string id;

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    private string corps;

    public string Corps
    {
        get { return corps; }
        set { corps = value; }
    }

    private double salary;

    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    private string firstName;

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    private string lastName;

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public Engineer(string id, string firstName, string lastName, double salary, string corps)
    {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.salary = salary;
        this.corps = corps;
        
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"Name: {firstName} {lastName} Id: {id} Salary: {salary.ToString("F2")}")
            .AppendLine($"Corps: {corps}")
            .AppendLine("Repairs:");
       
        return stringBuilder.ToString().TrimEnd();
    }
}
