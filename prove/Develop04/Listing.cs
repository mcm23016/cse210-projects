public class Listing : Activity
{
    // Class States
    List<string> _imPrompts = new List<string>();

    // Class Constructor
    public Listing(int duration) : base(
        duration,
        "Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        ) {
            // Add prompts to Prompts list
            _imPrompts.Add("Who are people that you appreciate?");
            _imPrompts.Add("What are personal strengths of yours?");
            _imPrompts.Add("Who are people that you have helped this week?");
            _imPrompts.Add("When have you felt the Holy Ghost this month?");
            _imPrompts.Add("Who are some of your personal heroes?");

        }

    // Class Methods
    public override void ImMiddle()
    {
        // Tells the user to be ready
        Console.WriteLine("Get ready...");
        ImAnimation(3);

        // Get a random prompt index
        Random randomGenerator = new Random();
        int promptIndex = randomGenerator.Next(0, _imPrompts.Count());

        // Tells user to list as many responses as they can to the prompt
        Console.WriteLine("List as many responses as you can to the following prompt\n");
        Console.WriteLine($"--- {_imPrompts.ElementAt(promptIndex)} ---\n");
        Console.Write("You may begin in: ");
        ImTimer(5);
        Console.WriteLine();

        // Gets the end time
        ImGetEndTime();

        // Runs rest of the activity
        int responseCount = 0;

        while(ImCheckTime())
        {
            Console.Write("> ");
            Console.ReadLine();
            responseCount ++;
        }

        Console.WriteLine($"You listed {responseCount} items!");
    }
        
}