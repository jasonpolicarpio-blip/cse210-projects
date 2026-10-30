using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int letterGrade = int.Parse(grade);

        if (letterGrade >= 90)
        {
            Console.WriteLine("You have an A.");
        }
        else if (letterGrade >= 80)
        {
            Console.WriteLine("You have a B.");
        }
        else if (letterGrade >= 70)
        {
            Console.WriteLine("You have a C.");
        }
        else if (letterGrade >= 60)
        {
            Console.WriteLine("You have a D.");
        }
        else
        {
            Console.WriteLine("You have an F.");
        }

        if (letterGrade >= 70)
        {
            Console.WriteLine("Congrats! You Passed.");
        }
        else
        {
            Console.WriteLine("Sorry. You did not pass.");
        }
    }
}