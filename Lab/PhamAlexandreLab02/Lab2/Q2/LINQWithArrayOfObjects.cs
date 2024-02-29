using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class LINQWithArrayOfObjects
    {
        static void Main(string[] args)
        {
            var employees = new[]
            {
                new Employee("Jason", "Red", 5000M),
                new Employee("Ashely", "Green", 7600M),
                new Employee("Matthew", "Indigo", 3587.5M),
                new Employee("James", "Indigo", 4700.77M),
                new Employee("Luke", "Indigo", 6200M),
                new Employee("Jason", "Blue", 3200M),
                new Employee("Wendy", "Brown", 4236.4M)
            };

            // Display all employees
            Console.WriteLine("Original array:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            // Filter salaries
            var between4K6K =
                from employee in employees
                where (employee.MonthlySalary >= 4000M) && (employee.MonthlySalary <= 6000M)
                select employee;

            // Display Employees making between 4000 and 6000 per month
            Console.WriteLine("\nEmployees earning in the range " + $"{4000:C}-{6000:C} per month:");
            foreach (var employee in between4K6K)
            {
                Console.WriteLine(employee);
            }

            // Order Employees by last name, then first name
            var nameSorted =
                from employee in employees
                orderby employee.LastName, employee.FirstName
                select employee;

            Console.WriteLine("\nFirst employee when sorted by name:");
            if (nameSorted.Any())
            {
                Console.WriteLine(nameSorted.First());
            }
            else
            {
                Console.WriteLine("not found");
            }

            // Select Last Names
            var lastNames =
                from employee in employees
                select employee.LastName;

            Console.WriteLine("\nUnique employee last names:");
            foreach (var employee in lastNames.Distinct())
            {
                Console.WriteLine(employee);
            }

            // Select First and Last names
            var names =
                from employee in employees
                select new { employee.FirstName, employee.LastName };

            Console.WriteLine("\nNames only:");
            foreach (var employee in names)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine();
        }
    }
}
