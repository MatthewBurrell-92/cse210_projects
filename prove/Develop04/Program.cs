using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        bool valid = false;
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
                // Console.WriteLine(" ");
                // Console.WriteLine("Breathing. ");
                // Console.WriteLine(" ");

                BreathingActivity breathing1 = new BreathingActivity();
                breathing1.DisplayBeginningMesasge();
                breathing1.SetSeconds();
            }

            else if (activity == 2)
            {
                // Reflection activity
                Console.WriteLine(" ");
                Console.WriteLine("Reflection. ");
                Console.WriteLine(" ");
            }

            else if (activity == 3)
            {
                // Listing activity
                Console.WriteLine(" ");
                Console.WriteLine("Listing. ");
                Console.WriteLine(" ");
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