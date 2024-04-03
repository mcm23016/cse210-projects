using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Ian", "Test Topic");
        Console.WriteLine(a.ImGetSummary());

        MathAssignment b = new MathAssignment("Ian", "Math Stuff", "7.2", "1-5 and 10-15");
        Console.WriteLine(b.ImGetSummary());
        Console.WriteLine(b.ImGetHomeworkList());

        WritingAssignment c = new WritingAssignment("Ian", "Writting Stuff", "Saddness");
        Console.WriteLine(c.ImGetSummary());
        Console.WriteLine(c.ImGetWritingInformation());
    }
}