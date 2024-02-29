using System;

class Program
{
    static void Main(string[] args)
    {
        // Gets the users First and Last names
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        // Prints the users First and Last names
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}