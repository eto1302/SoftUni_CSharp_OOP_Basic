using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Student : Human
{
    public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
    {
        FacultyNumber = facultyNumber;
    }

    public string facultyNumber;

    public string FacultyNumber
    {
        get
        {
            return facultyNumber;
        }
        set
        {
            if (value.Length < 5 || value.Length > 10 || !value.All(p => char.IsLetterOrDigit(p))) throw new ArgumentException("Invalid faculty number!");
            this.facultyNumber = value;
        }
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"First Name: {this.FirstName}")
            .AppendLine($"Last Name: {this.LastName}")
            .AppendLine($"Faculty number: {this.FacultyNumber}");
        return stringBuilder.ToString();
    }
}
