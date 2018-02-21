using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class Department
    {
        private List<Employee> employees;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    public Department(string name)
        {
           Employees = new List<Employee>();
            .name = name;
        }
        public List<Employee> Employees
        {
            get { return employees; }
            private set { employees = value; }
        }

        public decimal AverageSalary
        {
            get { return Employees.Select(e => e.salary).Average(); }
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
}

