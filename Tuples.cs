using System;

namespace term_paper
{
    class Tuples
    {
        static void Main(string[] args)
        {
            // A simple tuple, explicit types
            (String, int) simpleTuple = ("Bill", 2020);
		    Console.WriteLine("Simple Tuple: " + simpleTuple.ToString());
            Console.WriteLine();

            // A named tuple with field names, implicit types
            var employee = (Name: "Steve", Age: 30, Salary: 140170.95);
            Console.WriteLine("Original Tuple: " + employee.ToString());
            Console.WriteLine($"{employee.Name} of age {employee.Age} has a salary of ${employee.Salary}");
            Console.WriteLine();

            // Using a tuple from a function
            Console.WriteLine("Calling the function GetPerson()...");
            var person = GetPerson();
            Console.WriteLine($"The function returned the tuple: {person}");
            Console.WriteLine($"{person.Item1} is of age {person.Item2} and their favorite food is {person.Item3}");
            Console.WriteLine();

            // Comparing tuples for equality
            (int number, string grade) gradeOne = (98, "A");
            var gradeTwo = (num: 98, score: "A");
            Console.WriteLine($"Tuple 1: {gradeOne}");
            Console.WriteLine($"Tuple 2: {gradeTwo}");
            Console.WriteLine($"Is it true that both tuples are the same? {gradeOne == gradeTwo}");
            Console.WriteLine();
        }

        // A function that returns a tuple
        static Tuple<String, int, String> GetPerson()
        {
            return new Tuple<String, int, String>("Paul", 36, "Pizza");
        }
    }
}
