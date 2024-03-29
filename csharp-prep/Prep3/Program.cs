using System;

class Program
{
    static void Main(string[] args)
    {
        // Generates a magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        // Loops through program until user guesses correct number
        bool flag = true;
        while (flag) {

            // Gets a guess
            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());

            // Compares magic number to guess
            if (guess == magicNumber) // The guess is right 
            {
                Console.WriteLine("You guessed it!");
                flag = false;
            } 
            else if (guess > magicNumber) // The guess is too high
            {
                Console.WriteLine("Lower");
            }
            else // The guess must be too lower
            {
                Console.WriteLine("Higher");
            }
        }
    }   
}