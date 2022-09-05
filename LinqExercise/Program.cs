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
            Console.WriteLine(numbers.Sum());
            Console.WriteLine();

            //TODO: Print the Average of numbers
            Console.WriteLine(numbers.Average());
            Console.WriteLine();


            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("BREAK");
            Console.WriteLine();

            numbers.OrderBy(num => num).ToList().ForEach(asc => Console.WriteLine(asc));
            
            //foreach (var number in asc)
            //{
            //    Console.WriteLine(number);
            //}

            //TO
            //DO: Order numbers in decsending order adn print to the console
            Console.WriteLine("BREAK");
            Console.WriteLine();

            numbers.OrderByDescending(num => num).ToList().ForEach(desc => Console.WriteLine(desc));
            
            //foreach (var number in desc)
            //{   
            //    Console.WriteLine(number);
            //}

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("BREAK");
            Console.WriteLine();

            numbers.Where(num => num > 6).ToList().ForEach(Fish => Console.WriteLine(Fish));

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("BREAK");
            Console.WriteLine();

            var goDown = numbers.OrderByDescending(num => num).Take(4).ToList();

            foreach (var num in goDown)
            {
                Console.WriteLine(num);
            }

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine("BREAK");
            Console.WriteLine();

            numbers.SetValue(39, 4);

            numbers.OrderByDescending(change => change ).ToList().ForEach(num => Console.WriteLine(num));

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.
            Console.WriteLine("BREAK");
            Console.WriteLine();

            employees.FindAll(name => name.FirstName.ToLower()[0] == 'c' || name.FirstName.ToLower()[0] == 's')
                .OrderBy(name => name.FirstName).ToList().ForEach(split => Console.WriteLine(split.FullName));

            //foreach (var item in split)
            //{
            //    Console.WriteLine(item.FullName);
            //}

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("BREAK");
            Console.WriteLine();

            employees.Where(x => x.Age > 26).OrderByDescending(x => x.Age).ThenBy(x => x.FirstName)
                .ToList().ForEach(x => Console.WriteLine($"{x.FullName} {x.Age}"));  

            //foreach (var item in a)
            //{
            //    Console.WriteLine($"{item.FullName} {item.Age}");
            //}

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35
            Console.WriteLine("BREAK");
            Console.WriteLine();

            var yoe = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);

            Console.WriteLine($"{yoe.Sum(x => x.YearsOfExperience)}");
            Console.WriteLine($"{yoe.Average(x => x.YearsOfExperience)}");

            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("BREAK");
            Console.WriteLine();

            employees.Append(new Employee("Donte'", "Fisher", 39, 1)).ToList().ForEach(Fish => Console.WriteLine
            ($"{Fish.FullName}, {Fish.Age}, {Fish.YearsOfExperience}"));

            //foreach (var item in Fish)
            //{
            //    Console.WriteLine($"{item.FullName}, {item.Age}, {item.YearsOfExperience}");
            //}





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
