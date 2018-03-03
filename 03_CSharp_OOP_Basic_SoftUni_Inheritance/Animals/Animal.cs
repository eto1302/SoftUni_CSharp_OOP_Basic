using System;
using System.Collections.Generic;
using System.Text;


public abstract class Animal
{
    
    private string name;
    private int age;
    private string gender;

    public Animal(string name, int age, string gender)
    {
        
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    private string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
            {
                throw new ArgumentException("Invalid input!");
            }

            this.name = value;
        }
    }

    private int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid input!");
            }

            this.age = value;
        }
    }

    private string Gender
    {
        get
        {
            return this.gender;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
            {
                throw new ArgumentException("Invalid input!");
            }

            this.gender = value;
        }
    }

    public abstract string ProduceSound();
    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"{this.GetType().Name}")
            .AppendLine($"{this.name} {this.age} {this.gender}")
            .AppendLine(this.ProduceSound());
        string result = stringBuilder.ToString().TrimEnd();
        return result;
    }
}
