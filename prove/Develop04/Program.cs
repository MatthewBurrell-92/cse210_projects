using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        int activity = 0;
        while (quit == false)
        {
            Console.WriteLine("Menu options: ");
            Console.WriteLine("1. Breathing Activity ");
            Console.WriteLine("2. Reflection Activity ");
            Console.WriteLine("3. Listing Activity ");
            Console.WriteLine("4. Quit ");
            Console.Write("Please choose an option from the menu: ");
            string input = Console.ReadLine();
            int.TryParse(input, out activity);

            if (activity == 1)
            {
                // Breathing activity
                BreathingActivity breathing1 = new BreathingActivity();
                // breathing1.DisplayBeginningMesasge();
                breathing1.RunBreathingActivity();
                // breathing1.Duration();
                // breathing1.GetDuration();
            }

            else if (activity == 2)
            {
                // Reflection activity
                ReflectionActivity reflection1 = new ReflectionActivity();
                // reflection1.DisplayBeginningMessage();
                reflection1.RunReflectionActivity();
                // reflection1.Duration();
            }

            else if (activity == 3)
            {
                // Listing activity
                ListingActivity listing1 = new ListingActivity();
                listing1.RunListingActivity();
                // listing1.Duration();
            }

            else if (activity == 4)
            {
                // quit
                quit = true;
            }

            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("I'm sorry, I didn't understand. ");
                Console.WriteLine("Please enter a number between 1 and 4. ");
                Console.WriteLine(" ");
            }
        }
    }
    static bool ValidateInput(string input)
    {
        int number;
        if (int.TryParse(input, out number))
        {
            if (number >= 1 && number <= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}