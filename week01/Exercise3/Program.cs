using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            // Generate a random magic number
            int magicNumber = random.Next(1, 101);
            int guess = -1;
            int attempts = 0;

            // Loop until the user guesses the magic number
            while (guess != magicNumber)
            {
                // Ask the user for a guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                // Determine if the guess is higher, lower, or correct
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Inform the user of the number of attempts
            Console.WriteLine($"It took you {attempts} attempts to guess the magic number.");

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine();
            if (response.ToLower() != "yes")
            {
                playAgain = false;
            }
        }
    }
}
