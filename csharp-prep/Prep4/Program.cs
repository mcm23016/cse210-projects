using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates an int list 
        List<int> numbers = new List<int>();

        // Instructions for user
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Loops through asking user for numbers until they enter 0
        int enteredNumber = 1; // Temporary Value so it enters the loop

        while (enteredNumber != 0)
        {
            // Gets number from user and adds it to numbers list
            Console.Write("Enter a number: ");
            enteredNumber = int.Parse(Console.ReadLine());
            numbers.Add(enteredNumber);
        }

        // Calculates Sum
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        // Prints the Sum
        Console.WriteLine($"The sum is: {sum}");

    }
}