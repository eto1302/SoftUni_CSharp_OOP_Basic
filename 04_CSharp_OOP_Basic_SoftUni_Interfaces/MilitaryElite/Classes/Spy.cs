using System;
using System.Collections.Generic;
using System.Text;


class Spy : ISpy
{
    private string id;
    private string firstName;
    private string lastName;
    private int codeNumber;

    public string Id
    {
        get { return id; }
    }

    public string FirstName
    {
        get { return firstName; }
    }

    public string LastName
    {
        get { return lastName; }
    }

    public int CodeNumber
    {
        get { return codeNumber; }
    }

    public Spy(string id, string firstName, string lastName, int codeNumber)
    {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.codeNumber = codeNumber;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"Name: {firstName} {lastName} Id: {id}")
            .AppendLine($"Code Number: {codeNumber}");
        return stringBuilder.ToString().TrimEnd();
    }
}
