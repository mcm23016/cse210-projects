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

                // Decides what to do
                switch(imUserChoice)
                {
                    case "1":
                        // Breathing Activity
                        break;
                    case "2":
                        // Listing Activity
                        break;
                    case "3":
                        // Reflecting Activity
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