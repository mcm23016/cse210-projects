using System;
using System.IO; 
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // Important Holders of Data
        int imPoints;
        List<Goal> imGoals = new List<Goal>();

        // Menu functions
        void ImCreateNewGoal()
        {
            // Creates new goals from user input
            int imUserInput = 0;

            while(imUserInput != '1' || imUserInput != '1' || imUserInput != '1')
            {
                // Print options
                Console.WriteLine("The types of goals are :");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");

                // Get user choice
                Console.Write("What kind of goal do you want to make? ");
                imUserInput = Console.Read();
                Console.WriteLine(); // Blank Line

                // Run selected option
                switch(imUserInput)
                {
                    case '1':
                        // SImple Goal
                        
                        
                        
                        
                        
                        imGoals.Add(SimpleGoal());
                        break;

                    case '2':
                        // Eternal Goal
                        
                        
                        
                        
                        imGoals.Add(EternalGoal());
                        break;

                    case '3':
                        // Checklist Goal
                        



                        imGoals.Add(ChecklistGoal());
                        break;

                    default:
                        // Catches everything else.
                        Console.WriteLine("Error: Enter a number 1-3.");
                        break;

        }

        void ImListGoals()
        {
            // Foreach goal in goal list, list it out
            foreach(Goal goal in imGoals)
            {
                Console.WriteLine("*****Goal Information*****");
            }
        }

        void ImSaveGoals()
        {
            // Call all goal toStrings and save it.
            //get user to enter file name
            Console.Write("");
            string imFileName = "myFile.txt";

            using (StreamWriter outputFile = new StreamWriter(imFileName))
            {

                // outputFile.WriteLine("This will be the first line in the file.");
                // For each write it to file.
                foreach(Goal goal in imGoals)
                {
                    
                    outputFile.WriteLine($"Something :)");
                }
            }

        }

        void ImLoadGoals()
        {
            // Make list of goals from a file.

            /*
            string filename = "myFile.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string firstName = parts[0];
                string lastName = parts[1];
            }
        */
        
        }

        void ImRecordEvent()
        {
            // List out goals and allow user to complete one.
            ImListGoals();

            
        }

        // Menu here :)
        void RunMenu ()
        {
            int imUserInput = 0;

            while(imUserInput != '6')
            {
                // Print menu
                Console.WriteLine();

                // Get user choice
                Console.WriteLine();
                imUserInput = Console.Read();
                Console.WriteLine();

                // Run selected option
                switch(imUserInput)
                {
                    case '1':
                        // Create New Goal
                        ImCreateNewGoal();
                        break;

                    case '2':
                        // List Goals
                        ImListGoals();
                        break;

                    case '3':
                        // Save Goals
                        ImSaveGoals();
                        break;

                    case '4':
                        // Loads Goals
                        ImLoadGoals();
                        break;
                    
                    case '5':
                        // Record Event
                        ImRecordEvent();
                        break;

                    case '6':
                        // Quits
                        // It doesn't do anything. The while loop stops when == 6
                        break;
                        
                    default:
                        // Catches everthing else
                        Console.WriteLine("Error: Enter a number 1-5."); 
                        break;

                }
            }
        }

        // Run menu
        RunMenu();
    }   
}