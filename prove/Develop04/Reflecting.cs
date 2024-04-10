public class Reflecting : Activity
{
    // Class States
    List<string> _imPrompts = new List<string>();
    List<string> _imQuestions = new List<string>();

    // Class Constructor
    public Reflecting(int duration) : base(
        duration,
        "Reflecting",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
        ) {
            // Add prompts to Prompts list
            _imPrompts.Add("Think of a time when you stood up for someone else.");
            _imPrompts.Add("Think of a time when you did something really difficult.");
            _imPrompts.Add("Think of a time when you helped someone in need.");
            _imPrompts.Add("Think of a time when you did something truly selfless.");

            // Add questions to Questions list
            _imQuestions.Add("Why was this experience meaningful to you?");
            _imQuestions.Add("Have you ever done anything like this before?");
            _imQuestions.Add("How did you get started?");
            _imQuestions.Add("How did you feel when it was complete?");
            _imQuestions.Add("What made this time different than other times when you were not as successful?");
            _imQuestions.Add("What is your favorite thing about this experience?");
            _imQuestions.Add("What could you learn from this experience that applies to other situations?");
            _imQuestions.Add("What did you learn about yourself through this experience?");
            _imQuestions.Add("How can you keep this experience in mind in the future?");
        }

    // Class Methods
    public override void ImMiddle()
    {
        // Gets user ready
        Console.WriteLine("Get ready...");
        ImAnimation(3);

        // Selects random index for the prompt
        Random randomGenerator = new Random();
        int promptIndex = randomGenerator.Next(0, _imPrompts.Count());

        // Writes random prompt and waits for the user to be ready
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {_imPrompts.ElementAt(promptIndex)} ---\n");
        Console.Write("Press enter when you are ready: ");
        Console.ReadLine();
        Console.WriteLine();

        // Tells the user to ponder and answer the questions followed by a 5 second timer
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ImTimer(5);

        // Clears the console and gets the ending time
        Console.Clear();
        ImGetEndTime();

        // Runs the rest of the activity
        while(ImCheckTime())
        {
            int questionIndex = randomGenerator.Next(0, _imQuestions.Count());
            Console.WriteLine(_imQuestions.ElementAt(questionIndex));
            ImAnimation(9);
            ImAnimation(9);

        }
    }
        
}