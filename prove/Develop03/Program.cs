using System;

class Program
{
    static void Main(string[] args)
    {
        void ImGetScripture()
        {
            // Help the user know what they are entering
            Console.WriteLine("Please enter the information of the scripture you want to memorize:");
            
            // Gets scripture refrence
            Console.Write("Refrence: ");
            string imRefrence = Console.ReadLine();

            // Gets scripture passage
            Console.Write("Passage: ");
            string imPassage = Console.ReadLine(); 

            // Creates Scripture object
            Scripture s = new Scripture(imRefrence, imPassage);
        }






        // Code to run
        ImGetScripture();
        ImHideWords();
    }
}