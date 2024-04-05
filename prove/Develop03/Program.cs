/*
CSE 210

Extras:
1. I made it so the program only hides words that haven't already been hidden
2. I made it so the user controls how many words they want to have hidden.
*/


using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Scripture ImGetScripture()
        {
            // Help the user know what they are entering
            Console.WriteLine("Please enter the information of the scripture you want to memorize:");
            
            // Gets scripture refrence
            Console.Write("Refrence: ");
            string imRefrence = Console.ReadLine();

            // Gets scripture passage
            Console.Write("Passage: ");
            string imPassage = Console.ReadLine(); 
            
            // Creates and returns Scripture object
            Scripture scripture = new Scripture(imRefrence, imPassage);
            return scripture;

        }

        void QuizScripture(Scripture scripture)
        {
            // Gets the amount of words to hide each round
            Console.Write("Words to be hidden each round: ");
            int imHideAmount = int.Parse(Console.ReadLine()); 

            // Clear console
            Console.Clear();

            // Initilizing a value so the word hiding while loop starts
            int imHideWords = 1;

            while (imHideWords == 1)
            {
                // Hides words
                imHideWords = scripture.ImHideWords(imHideAmount);

                // Dispalys current scripture with hidden words
                Console.WriteLine(scripture.ImGetCurrentString());

                //Asks user if they want to continue or quit
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                string response = Console.ReadLine();
                if (response == "quit") {break;}
                Console.Clear();

            }
        }

        // Code to run
        Scripture imScripture = ImGetScripture();
        QuizScripture(imScripture);

    }
}