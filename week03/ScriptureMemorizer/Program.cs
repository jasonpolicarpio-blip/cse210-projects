using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, scriptureText);

        string input = "";

        while (input != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();

            if (input != "quit")
            {
                scripture.HideRandomWords(1);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}