using System;
using System.Collections.Generic;
using System.Text;


public class Worker : Human
{
    public Worker(string firstName, string lastName, decimal weekSalary, decimal workingHours) : base(firstName, lastName)
    {
        WeekSalary = weekSalary;
        WorkingHours = workingHours;
    }

    public decimal weekSalary;
    public decimal workingHours;
    public decimal WeekSalary
    {
        get
        {
            return this.weekSalary;
        }
        set
        {
            if (value <= 10) throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
            this.weekSalary = value;
        }
    }
    public decimal WorkingHours
    {
        get
        {
            return this.workingHours;
        }
        set
        {
            if (value > 12 || value < 1) throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
            this.workingHours = value;
        }
    }

    public override string ToString()
    {
        decimal salaryPerHour = Convert.ToDecimal(this.WeekSalary) / (Convert.ToDecimal(this.WorkingHours) * 5);
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"First Name: {this.FirstName}")
            .AppendLine($"Last Name: {this.LastName}")
            .AppendLine($"Week Salary: {this.WeekSalary:f2}")
            .AppendLine($"Hours per day: {this.WorkingHours:f2}")
            .AppendLine($"Salary per hour: {salaryPerHour:f2}");
        return stringBuilder.ToString().TrimEnd();
    }
}
