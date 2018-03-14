using System;
using System.Collections.Generic;
using System.Text;


class Private : IPrivate
{
    private double salary;

    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    private string id;

    public string Id
    {
        get { return id; }
        set { id = value; }
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

    public Private(string id, string firstName, string lastName, double salary)
    {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.salary = salary;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"Name: {firstName} {lastName} Id: {id} Salary: {salary.ToString("F2")}");
        return stringBuilder.ToString().TrimEnd();
    }
}

