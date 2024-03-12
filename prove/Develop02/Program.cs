/*
Ian McMaster
CSE  210

Resources used:
https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
https://learn.microsoft.com/en-us/dotnet/csharp/how-to/concatenate-multiple-strings
https://www.w3schools.com/cs/cs_switch.php
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Entry entry1 = new Entry();
        entry1._imDate = "DATE";
        entry1._imPrompt = "PROMPT";
        entry1._imResponse = "RESPONSE";
        Console.WriteLine(entry1.toCSV());
        */

        string ImGetJournalPrompt()
        {
            string imPrompt = "";
            return imPrompt;
        }

        void ImWriteEntry()
        {
            // Prints out a random prompt for the user
            string imPrompt = ImGetJournalPrompt();
            Console.WriteLine(imPrompt);
            
            //Gives the user a carrot to write response and reads the response.
            Console.Write("> ");
            string imResponse = Console.ReadLine();

            
        }


        void ImDisplayFile()
        {
            // Code here
        }


        void ImLoadFile()
        {
            Console.Write("Enter a file name to save the journal to: ");
            Console.ReadLine();
        }


        void ImSaveFile()
        {
            // Code here 
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
                        // code block
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