// Used https://learn.microsoft.com/en-us/dotnet/api/system.math.log?view=net-8.0 for math log functions

using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        static void ImMenu()
        {
            // Variable for user choice
            string imUserChoice = "";
            int _imDuration = 0;

            while(imUserChoice != "4")
            {
                // Displays menu
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Start Breathing Activity");
                Console.WriteLine("2. Start Listing Activity");
                Console.WriteLine("3. Start Reflecting Activity");
                Console.WriteLine("4. Quit");
                
                // Gets user choice
                Console.Write("Select a choice from the menu: ");
                imUserChoice = Console.ReadLine();

                // Exits if user entered "4"
                if (imUserChoice == "1" || imUserChoice == "2" || imUserChoice == "3")
                {
                    // Gets activity duration, then clears console for activity
                    Console.Write("Set the activity duration (seconds): ");
                    _imDuration = int.Parse(Console.ReadLine());
                    Console.Clear();
                }

                // Decides what to do
                switch(imUserChoice)
                {
                    case "1":
                        // Breathing Activity
                        Breathing breathing = new Breathing(_imDuration);
                        breathing.ImRun();
                        break;
                    case "2":
                        // Listing Activity
                        Listing listing = new Listing(_imDuration);
                        listing.ImRun();
                        break;
                    case "3":
                        // Reflecting Activity
                        Reflecting reflecting = new Reflecting(_imDuration);
                        reflecting.ImRun();
                        break;
                    case "4":
                        // Quit
                        break;
                    default:
                        //Catches all else
                        Console.WriteLine("Error: Enter a number 1-4");
                        break;
                }
                
            }
        }


        ImMenu();
    }
}