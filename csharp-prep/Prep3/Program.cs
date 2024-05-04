using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is your magic number? ");
        // string userInput = Console.ReadLine();
        // int magicNumber = int.Parse(userInput);

        string playOn = "Yes";
        while (playOn == "Yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,100);
            int guessNumber = -1;
            int guesses = 0;
            while (guessNumber != magicNumber)
            {
                Console.Write("What is your guess? ");
                string userInput = Console.ReadLine();
                guessNumber = int.Parse(userInput);
                if (magicNumber > guessNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guessNumber)
                {
                    Console.WriteLine("Lower");
                }
                guesses += 1;
            }
            Console.WriteLine("Congrats, you guessed the number! ");
            Console.WriteLine($"It took you {guesses} attempts. ");
            Console.Write("Would you like to play again? Yes or No: ");
            playOn = Console.ReadLine();
        }
        
    }
}