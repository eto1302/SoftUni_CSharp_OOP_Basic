using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

public class Human
{
    public string firstName;
    public string lastName;

    public virtual string FirstName
    {
        get
        {
            return firstName;
        }
        set
        {
            if (!char.IsUpper(value.First())) throw new ArgumentException($"Expected upper case letter! Argument: firstName");
            else if (value.Length <= 3) throw new ArgumentException($"Expected length at least 4 symbols! Argument: firstName");
            else this.firstName = value;
        }
    }
    public virtual string LastName
    {
        get
        {
            return lastName;
        }
        protected set
        {
            if (!char.IsUpper(value.First())) throw new ArgumentException($"Expected upper case letter! Argument: lastName");
            if (value.Length <= 2) throw new ArgumentException($"Expected length at least 3 symbols! Argument: lastName ");
            this.lastName = value;
        }
    }

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }
}
