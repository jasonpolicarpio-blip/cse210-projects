using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Journal journal = new Journal();
        string choice = "";


        while (choice != "5")
        {
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save entries to a file");
            Console.WriteLine("4. Load entries from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                PromptGenerator randomPrompt = new PromptGenerator();
                string prompt = randomPrompt.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();
                Entry entry = new Entry();
                entry._promptText = prompt;
                entry._entryText = response;
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {

                journal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.Write("What is the name of the file? ");
                string fileName = Console.ReadLine();

                journal.SaveToFile(fileName);
            }
            else if (choice == "4")
            {
                Console.Write("What is the name of the file? ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Exiting the Journal Program. Goodbye!");
            }


        }

    }
}