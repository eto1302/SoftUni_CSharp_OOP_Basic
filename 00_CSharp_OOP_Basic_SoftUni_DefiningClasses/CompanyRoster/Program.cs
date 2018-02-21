using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();
            int peopleCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < peopleCount; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string name = tokens[0];
                decimal salary = decimal.Parse(tokens[1]);
                string position = tokens[2];
                string departmentName = tokens[3];
                string email = "n/a";
                int age = -1;
                if (tokens.Length == 6)
                {
                    email = tokens[4];
                    age = int.Parse(tokens[5]);
                }
                else if (tokens.Length == 5)
                {
                    bool isAge = int.TryParse(tokens[4],out age);
                    if (!isAge)
                    {
                        email = tokens[4];
                        age = -1;
                    }
                    
                }
                
                if (!departments.Any(d => d.Name == departmentName))
                {
                    Department dep = new Department(departmentName);
                    departments.Add(dep);
                }
                var department = departments.FirstOrDefault(d => d.Name == departmentName);
                Employee employee = new Employee(name,salary,position,departmentName,email,age);
                department.AddEmployee(employee);
                
            }
            var highestAvgDep = departments.OrderByDescending(d => d.AverageSalary).First();
            Console.WriteLine($"Highest Average Salary: {highestAvgDep.Name}");
            foreach (var emp in highestAvgDep.Employees.OrderByDescending(e => e.salary))
            {
                Console.WriteLine($"{emp.name} {emp.salary:f2} {emp.email} {emp.age}");
            }
        }

        
    }
}