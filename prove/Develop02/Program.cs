/*
Ian McMaster
CSE  210

Resources used:
https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
https://learn.microsoft.com/en-us/dotnet/csharp/how-to/concatenate-multiple-strings
https://www.w3schools.com/cs/cs_switch.php
*/

using System;
using System.IO; 
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        Journal imJournal = new Journal();
        // List<Entry> imEntries = new List<Entry>();

        string ImGetJournalPrompt()
        {
            List<String> prompts = new List<String>();
            prompts.Add("Who was the most interesting person I interacted with today?");
            prompts.Add("What was the best part of my day?");
            prompts.Add("How did I see the hand of the Lord in my life today?");
            prompts.Add("What was the strongest emotion I felt today?");
            prompts.Add("If I had one thing I could do over today, what would it be?");
            prompts.Add("What did you feel grateful for today?");
            prompts.Add("What was something I learned today?");
            prompts.Add("Did you serve anyone today?");
            prompts.Add("Did anyone serve you today?");
            prompts.Add("You got this, use your brain to write something!");

            // Generates a random number
            Random randomGenerator = new Random();
            int imRandomNumber = randomGenerator.Next(0, prompts.Count-1);

            // Returns a random prompt
            return prompts.ElementAt(imRandomNumber);
        }

        void ImWriteEntry()
        {
            // Prints out a random prompt for the user
            string imPrompt = ImGetJournalPrompt();
            Console.WriteLine(imPrompt);
            
            // Gets the current date and shortens it
            DateTime imCurrentDate = DateTime.Now;
            string imDate = imCurrentDate.ToShortDateString();

            //Gives the user a carrot to write response and reads the response.
            Console.Write("> ");
            string imResponse = Console.ReadLine();

            // Asks the user to rate the day
            Console.Write("How would you overal rate today (1-10): ");
            string _imDailyRating = Console.ReadLine();


            // Creates new entry
            imJournal.ImNewEntry(imDate, imPrompt, imResponse, _imDailyRating);
        }


        void ImDisplayFile()
        {
            string imJournalString = imJournal.ImToString();
            Console.WriteLine(imJournalString);
        }


        void ImLoadFile()
        {
            Console.Write("Enter a file name to load the journal from: ");
            string imFileName = Console.ReadLine();

            string[] lines = System.IO.File.ReadAllLines(imFileName);

            foreach (string line in lines)
            {
                if (line != "")
                {
                     string[] parts = line.Split("~~");

                    string date = parts[0];
                    string prompt= parts[1];
                    string response = parts[2];
                    string dailyRating = parts[3];

                    imJournal.ImNewEntry(date, prompt, response, dailyRating);

                }
            }

        }


        void ImSaveFile()
        {
            Console.Write("Enter a file name to save the journal to: ");
            string imFileName = Console.ReadLine();
            string imJournalCSV = imJournal.ImToCSV();

            using (StreamWriter outputFile = new StreamWriter(imFileName))
            {
                outputFile.WriteLine(imJournalCSV);
            }

        }

        void ImMainMenu(){
        
            // Funtion variable
            int imUserChoice = 0;

            // Main Menu
            while (imUserChoice != 5) 
            {


                // Prints out the menu
                Console.WriteLine("Select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do? ");
                
                // Reads the users choice
                imUserChoice = int.Parse(Console.ReadLine());

                // Blank line to be more readable
                Console.WriteLine();

                // Selects funtion to run based off of user input
                switch(imUserChoice) 
                {
                    case 1:
                        ImWriteEntry();
                        break;
                    case 2:
                        ImDisplayFile();
                        break;
                    case 3:
                        ImLoadFile();
                        break;
                    case 4:
                        ImSaveFile();
                        break;
                    case 5:
                        Console.Write("Did you remember to save your journal?\nAre you sure you want to quit? (y or n) ");
                        string response = Console.ReadLine();
                        if (response == "n")
                        {
                            imUserChoice = 0;
                            break;
                        }
                        // Else does nothing and exits while loop
                        break;
                    default:
                        Console.WriteLine("Error: Enter a number 1-5");
                        break;
                }
            }
        }
    
        
        // Code that runs
        ImMainMenu();
    }
}