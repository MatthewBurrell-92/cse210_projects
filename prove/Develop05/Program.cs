using System;

class Program
{
    static void Main(string[] args)
    {
        // Update with points thing
        Console.WriteLine("You have 0 points. ");
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        string choice = Console.ReadLine();

    }
    static void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");
        Console.WriteLine("Which type of Goal would you like to create? ");
        string input = Console.ReadLine();
        if (ValidateInput(input,3))
        {
            int goalType = int.Parse(input);
            if (goalType == 1)
            {
                Goal simpleGoal1 = new SimpleGoal();
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
            Console.ReadLine("Press enter to continue. ");
        }
    }
    
    static bool ValidateInput(string input, int total_options)
    {
        int number;
        if (int.TryParse(input, out number))
        {
            if (number >= 1 && number <= total_options)
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