public class Breathing : Activity
{
    // Class States

    // Class Constructor
    public Breathing(int duration) : base(
        duration,
        "Breathing",
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
        ) {}

    // Class Methods
    public override void ImMiddle()
    {   
        Console.WriteLine("Get ready...");
        ImAnimation(3);

        ImGetEndTime();

        while(ImCheckTime())
        {
            ImFancierBreathingAnimation();


            /*
            Less Fancy Breathing Animation

            // Breath in 
            Console.Write("Breath in...");
            ImTimer(4);
            Console.Write(" \n");

            // Breath out 
            Console.Write("Breath Out...");
            ImTimer(6);
            Console.Write(" \n\n");
            */
        } 
    }

    public void ImFancierBreathingAnimation()
    {
        Console.Write("Breath in: ");
        // 10 "-" written fast then slow
        int dashAmount = 10;
        double x = 0.00;
        while (dashAmount > 0)
        {
            // Writes a Dash, waits, and does math.
            Console.Write("-");
            // -5 * log(x+1) + 6
            double y = 200 * (5 * Math.Pow(2, 0.6 * x - 5));
            int milliseconds = (int)y;
            Thread.Sleep(milliseconds);
            dashAmount --;
            x ++;

        }

        // Deletes all dashes and creates breath ou twith all dashes
        Console.Write("\b \b\b \b\b \b\b \b\b \b\b \b\b \b\b \b\b \b\b \n");
        Console.Write("Breath out: ---------- ");
        // Deletes 10 "-" fast and then slow
        dashAmount = 10;
        x = 0.00;
        while (dashAmount > 0)
        {
            // Writes a Dash, waits, and does math.
            Console.Write("\b\b ");
            double y = 100 * (5 * Math.Pow(2, 0.7 * x - 5));
            int milliseconds = (int)y;
            Thread.Sleep(milliseconds);
            dashAmount --;
            x ++;

        }
        Console.WriteLine("\n");
    }

}