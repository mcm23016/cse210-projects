using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        void DisplayWelcome()
        {
            // Displays the message, "Welcome to the Program!"
            Console.WriteLine("Welcome to the program!");
        }

        string PromptUserName()
        {
            // Asks for and returns the user's name (as a string)
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        int PromptUserNumber()
        {
            // Asks for and returns the user's favorite number (as an integer)
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        int SquareNumber(int p_number)
        {
            // Accepts an integer as a parameter and returns that number squared (as an integer)
            int number = p_number * p_number;

            return number;
        }

        void DisplayResult(string p_name, int p_number)
        {
            // Accepts the user's name and the squared number and displays them.
            Console.WriteLine($"{p_name}, the square of your number is {p_number}");
        }

        DisplayWelcome();  
        string name = PromptUserName();  
        int number = PromptUserNumber(); 
        int squaredNumber = SquareNumber(number);  
        DisplayResult(name, squaredNumber);  
    }
}