using System;
using System.Collections.Generic;

namespace DictionaryPractice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary Practice2");
            // Data Base
            Employee[] employees =
            {
                new Employee("CEO","Smith",23,200),
                new Employee("Manager","Johnson",35,100),
                new Employee("Saler","Brown",42,105),
                new Employee("Saler","Taylor",32,185),
                new Employee("Saler","Anderson",27,25),
                new Employee("Manager","Brown",25,123),
            };

            // Dictionary
            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                // Check if the role already exists in the dictionary
                if (!employeesDirectory.ContainsKey(emp.Role))
                {
                    employeesDirectory.Add(emp.Role, emp);
                }
            }


            //for user input
            string key = "CEO";
            if (employeesDirectory.ContainsKey(key))
            {
                Employee empl = employeesDirectory["CEO"];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2} ", empl.Name, empl.Role, empl.Salary);
            }
            else
            {
                Console.WriteLine("No Employee found with this key {0} " , key);
            }
        }
    }

    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        public Employee(string role, string name, int age, float rate) // Changed 'int v' to 'float rate'
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate; // Properly assign the Rate
        }
    }
}