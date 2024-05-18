using System;

class Program
{
    static void Main(string[] args)
    {
        int command = 0;
        while (command != 5)
        {
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Quit ");
            command = prompt_input();
            if (command = 1)
            {
                Console.WriteLine("thinks");;
            }
        }
    }

    static int prompt_input()
    {
        bool valid = false;
        string input = "";
        while (valid == false)
        {
        Console.Write("> ");
        input = Console.ReadLine();
        valid = validate_input(input);
        if (!valid)
        {
            Console.WriteLine("Invalid response. Try again. ");
        }
        }
        int command = int.Parse(input);
        return command;
    }
    static bool validate_input(string input)
    {
        int number;
        if (int.TryParse(input, out number))
        {
            if (number >= 1 && number <= 5)
            {
                Console.WriteLine("works");
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