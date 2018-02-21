using System;
using System.Collections.Generic;
using System.Text;

    public class Employee
    {
        public string name;
        public decimal salary;
        public string position;
        public string email;
        public int age;

        public Employee(string name, decimal salary, string position, string department, string email = "n/a",
            int age = -1)
        {
            Name = name;
            Position = position;
            Salary = salary;
            Age = age;
            Email = email;
        }
        
        private string Name
        {
            get { return name; }
            set { name = value; }
        }
        private decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        private string Position
        {
            get { return position; }
            set { position = value; }
        }
        
        private string Email
        {
            get { return email; }
            set { email = value; }
        }

        private int Age
        {
            get { return age; }
            set { age = value; }
        }

    }

