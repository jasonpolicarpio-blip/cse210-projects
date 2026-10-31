using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guessNumber = -1;


        while (guessNumber != number)
        {

            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());


            if (guessNumber < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Congrats! You guessed it.");
            }
        }
    }
}