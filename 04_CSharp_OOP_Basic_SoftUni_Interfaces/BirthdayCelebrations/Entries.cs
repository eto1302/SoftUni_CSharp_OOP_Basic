using System;
using System.Collections.Generic;
using System.Text;


class Entries: IId, IBirthable
{
    private DateTime birthDate;
    private string name;
    private string id;
    private string type;

    public string Type
    {
        get
        {
            return this.type;
        }

        set
        {
            this.type = value;
        }
    }

    public DateTime BirthDate
    {
        get
        {
            return this.birthDate;
        }

        set
        {
            this.birthDate = value;
        }
    }

    public string Name
    {
        get { return this.name; }

        set { this.name = value; }

    }

    public string Id
    {
        get { return this.id; }

        set { this.id = value; }

    }

    public Entries(string type, string name, string id, DateTime birthDate)
    {
        this.Type = type;
        this.Name = name;
        this.Id = id;
        this.BirthDate = birthDate;
    }

    public void PrintResults(int year)
    {
        if (this.Type == "Citizen" || this.Type == "Pet")
        {
            if (this.BirthDate.Year == year)
            {
                Console.WriteLine(this.BirthDate.ToString("dd/MM/yyyy"));
            }
        }
    }
}

