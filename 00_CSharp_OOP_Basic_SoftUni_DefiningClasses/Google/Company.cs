using System;
using System.Collections.Generic;
using System.Text;


    class Company
    {
        public string name;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string department;
        public string Department
        {
            get => department;
            set => department = value;
        }
        public decimal salary;
        public decimal Salary
        {
            get => salary;
            set => salary = value;
        }
    public Company(string newName, string newDepartment, decimal newSalary)
        {
            department = newDepartment;
            name = newName;
            salary = newSalary;
        }
}

