using System;
using System.Collections.Generic;
using System.Text;


public class Book
{
    public string title;
    public string author;
    public decimal price;

    public Book(string author, string title, decimal price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }

    public string Author
    {
        get
        {
            return author;
        }
        set
        {
           
            if (value.Split().Length >= 2) if (char.IsNumber(value.Split()[1][0])) throw new ArgumentException("Author not valid!");
            this.author = value;
        }
    }
    public virtual decimal Price
    {
        get
        {
            return price;
        }
        set
        {
            if (value <= 0) throw new ArgumentException("Price not valid!");
            this.price = value;
        }
    }
    public string Title
    {
        get
        {
            return title;
        }
        set
        {
            if (value.Length < 3) throw new ArgumentException("Title not valid!");
            this.title = value;
        }
    }

    public override string ToString()
    {
        var resultBuilder = new StringBuilder();
        resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:f2}");
        string result = resultBuilder.ToString().TrimEnd();
        return result;
    }
}
