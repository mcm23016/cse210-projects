using System;
using System.IO; 
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // Important Holders of Data
        int imPoints = 0;
        //List<int> imPoints = new List<int>();
        //imPoints.Add(0);
        List<Goal> imGoals = new List<Goal>();

        // Menu functions
        void ImCreateNewGoal()
        {
            // Creates new goals from user input
            string imUserInput = "";

            while(imUserInput != "1" && imUserInput != "2" && imUserInput != "3")
            {
                // Print options
                Console.WriteLine("The types of goals are :");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");

                // Get user choice
                Console.Write("What kind of goal do you want to make? ");
                imUserInput = Console.ReadLine();
                Console.WriteLine(""); // Blank Line

                // Run selected option
                switch(imUserInput)
                {
                    case "1":
                        // Simple Goal
                        
                        Console.Write("What is the name of this goal: ");
                        string name = Console.ReadLine();

                        Console.Write("Write a short description of the goal: ");
                        string description = Console.ReadLine();

                        Console.Write("How many points is this goal worth: ");
                        int points = int.Parse(Console.ReadLine());
                        
                        imGoals.Add(new SimpleGoal(name, description, points));
                        break;

                    case "2":
                        // Eternal Goal
                        
                        Console.Write("What is the name of this goal: ");
                        name = Console.ReadLine();

                        Console.Write("Write a short description of the goal: ");
                        description = Console.ReadLine();

                        Console.Write("How many points is this goal worth: ");
                        points = int.Parse(Console.ReadLine());
                        
                        
                        imGoals.Add(new EternalGoal(name, description, points));
                        break;

                    case "3":
                        // Checklist Goal
                        
                        Console.Write("What is the name of this goal: ");
                        name = Console.ReadLine();

                        Console.Write("Write a short description of the goal: ");
                        description = Console.ReadLine();

                        Console.Write("How many time will you complete this goal: ");
                        int completeAmount = int.Parse(Console.ReadLine());

                        Console.Write("How many points is this goal worth: ");
                        points = int.Parse(Console.ReadLine());


                        Console.Write("How many bonus points is the completed goal worth: ");
                        int bonusPoints = int.Parse(Console.ReadLine());

                        imGoals.Add(new ChecklistGoal(name, description, completeAmount, points, bonusPoints));
                        break;

                    default:
                        // Catches everything else.
                        Console.WriteLine("Error: Enter a number 1-3.");
                        break;
                }
            }
        }

        void ImListGoals()
        {
            // Foreach goal in goal list, list it out
            int i = 1;
            foreach(Goal goal in imGoals)
            {
                Console.WriteLine($"{i}.{goal.ImToString()}");
                i ++;
            }
        }

        void ImSaveGoals()
        {
            // Call all goal toStrings and save it.
            Console.Write("Enter a filename to save to: ");
            string imFileName = Console.ReadLine();


            using (StreamWriter outputFile = new StreamWriter(imFileName))
            {
                //Saves points earned
                outputFile.WriteLine($"Points~~{imPoints}");

                // Writes each line on the file 
                foreach(Goal goal in imGoals)
                {
                    // Class type~~PointsEarned~~Name~~Description~~PointValues~~Completed(Bool)~~Completed(int)~~CompletedOutOf(int)
                    outputFile.WriteLine(goal.ImToCSV());
                }
            }

        }

        void ImLoadGoals()
        {
            // Make list of goals from a file.
            // Gets user to enter file name
            Console.Write("Enter a filename to load from: ");
            string imFileName = Console.ReadLine();

            string[] lines = System.IO.File.ReadAllLines(imFileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split("~~");

                //Class type~~PointsEarned~~Name~~Description~~Completed(Bool)~~Completed(int)~~CompletedOutOf(int)~~PointValues~~BonusPointAmount

                if (parts[0] == "Points")
                {
                    imPoints = int.Parse(parts[1]);
                }
                else if  (parts[0] == "Simple")
                {
                    // Builds a Simple goal and adds it to goal list
                    imGoals.Add(new SimpleGoal(parts[2], parts[3], parts[4], int.Parse(parts[7])));
                }
                else if (parts[0] == "Eternal")
                {
                    // Builds an Eternal goal and adds it to goal list
                    imGoals.Add(new EternalGoal(parts[2], parts[3], int.Parse(parts[7])));
                }
                else if (parts[0] == "Checklist")
                {
                    // Builds a Checklist goal and adds it to goal list
                    imGoals.Add(new ChecklistGoal(parts[2], parts[3], parts[4], int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7])));
                }
            }
        
        }

        void ImRecordEvent()
        {
            // List out goals and allow user to complete one.
            ImListGoals();

            Console.Write("Which goal did you complete? ");
            int goalNumber = int.Parse(Console.ReadLine()) - 1;
            imPoints = imPoints + imGoals[goalNumber].ImComplete();
            
        }

        // Menu here :)
        void RunMenu ()
        {
            string imUserInput = "";

            while(imUserInput != "6")
            {
                Console.WriteLine($"You have {imPoints} points");

                // Print menu
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Create new goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");

                // Get user choice
                Console.Write("Enter a number 1-6: ");
                imUserInput = Console.ReadLine();
                Console.WriteLine();

                // Run selected option
                switch(imUserInput)
                {
                    case "1":
                        // Create New Goal
                        ImCreateNewGoal();
                        break;

                    case "2":
                        // List Goals
                        ImListGoals();
                        break;

                    case "3":
                        // Save Goals
                        ImSaveGoals();
                        break;

                    case "4":
                        // Loads Goals
                        ImLoadGoals();
                        break;
                    
                    case "5":
                        // Record Event
                        ImRecordEvent();
                        break;

                    case "6":
                        // Quits
                        // It doesn"t do anything. The while loop stops when == 6
                        break;
                        
                    default:
                        // Catches everthing else
                        Console.WriteLine("Error: Enter a number 1-6."); 
                        break;

                }
            }
        }

        // Run menu
        RunMenu();
    }   
}