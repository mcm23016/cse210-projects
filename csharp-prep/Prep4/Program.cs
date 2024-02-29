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
        while (true)
        {
            // Gets number from user and adds it to numbers list
            Console.Write("Enter a number: ");
            int enteredNumber = int.Parse(Console.ReadLine());

            // Exits loop if 0 is entered or adds it if it is something else
            if (enteredNumber == 0)
            {
                break;
            } 
            else
            {
                numbers.Add(enteredNumber);
            }
        }

        
        int sum = 0; // Initilizes sum
        int largestNumber = numbers[0]; // Sets the largest number the the first number in the list

        foreach (int number in numbers)
        {
            sum += number;
            if (number > largestNumber)
            {
                largestNumber = number;
            }

        }

        // Calculates the average
        double average = (double)sum / numbers.Count;

        // Prints the Sum, Average and Largest
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}