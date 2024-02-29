using System;

class Program
{
    static void Main(string[] args)
    {
        // Asks user for grade percentage 
        Console.Write("Enter your grade percentage: ");
        string userInput = Console.ReadLine();

        // Converts grade percentage string to an int
        int gradePercentage = int.Parse(userInput);


        // Decides the letter grade to give to the student and prints it out
        string letterGrade = "";

        if (gradePercentage >= 90){
            letterGrade = "A";
        } else if (gradePercentage >= 80){
            letterGrade = "B";
        } else if (gradePercentage >= 70){
            letterGrade = "C";
        } else if (gradePercentage >= 60){
            letterGrade = "D";
        } else {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is a(n) {letterGrade}");


        // Decides if the user passed and prints out a message
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("You did not pass, but failure is not the end. Try again!");
        }
    }
}