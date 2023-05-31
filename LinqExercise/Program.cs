using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("Sum of numbers");
            Console.WriteLine(numbers.Sum());

            //TODO: Print the Average of numbers
            Console.WriteLine("Totally Average");
            Console.WriteLine(numbers.Average());

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("I order ascending order for this order");
            var up = numbers.OrderBy(x => x);
            foreach (var x in up) Console.WriteLine(x);

            //TODO: Order numbers in descending order and print to the console
            Console.WriteLine("Going Down");
            var down = numbers.OrderByDescending(x => x);
            foreach (var y in down) Console.WriteLine(y);

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Six is the bar");
            var numbersAboveSix = numbers.Where(x => x > 6);
            foreach (var x in numbersAboveSix) 
            {
                Console.WriteLine(x);
            }
            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Four numbers for all numbers");
            var any = numbers.OrderBy(x => x);
            foreach (var x in any.Take(4)) 
            { 

                Console.WriteLine(x);
            }
            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            Console.WriteLine("I'm how old....");
            numbers[4] = 42;
            var numbersAsc = numbers.OrderByDescending(x => x);
            foreach (var x in numbersAsc)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("The dreaded employees...");
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("Names of the S and C that you see.");
            employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName.StartsWith('S'))
                .OrderBy(x => x.FirstName)
                .ToList()
                .ForEach(x => Console.WriteLine(x.FullName));

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Employees that are over 26");
            employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine($"Full Name: {x.FullName} Age: {x.Age}"));

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            Console.WriteLine("That about sums up the YOE..");
            int employeeSum = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);
            Console.WriteLine(employeeSum);
            Console.WriteLine("Average of YOE");
            double employeeAvg = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience);
            Console.WriteLine(employeeAvg);

            //TODO: Add an employee to the end of the list without using employees.Add()
            Employee newEmployee = new Employee();
            newEmployee.FirstName = "Ben";
            newEmployee.LastName = "Zellers";
            employees.Append(newEmployee).ToList().ForEach(x => Console.WriteLine(x.FullName));



            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
