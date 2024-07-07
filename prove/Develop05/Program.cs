using System;

class Program
{


    static void Main(string[] args)
    {
        List<Goal> Goals = new List<Goal>();
        Gamification game1 = new Gamification();
        // Goal simpleGoal1 = new SimpleGoal();
        // Goals.Add(simpleGoal1);
        bool quit = false;
        while (quit == false)
        {
            Console.WriteLine("");
            game1.DisplayPoints();
            Console.WriteLine("\nMenu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();
            int choice = -1;

            try
            {
                choice = int.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (choice == 1)
            {
                // CreateGoal();
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("    1. Simple Goal");
                Console.WriteLine("    2. Eternal Goal");
                Console.WriteLine("    3. Checklist Goal");
                Console.WriteLine("Which type of Goal would you like to create? ");
                string input2 = Console.ReadLine();
                int choice2 = -1;
                try
                {
                    choice2 = int.Parse(input2);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                if (choice2 == 1)
                {
                    Goals.Add(CreateGoal(1));
                }
                else if (choice2 == 2)
                {
                    Goals.Add(CreateGoal(2));
                }
                else if (choice2 == 3)
                {
                    Goals.Add(CreateGoal(3));
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 3. ");
                }
            }
            else if (choice == 2)
            {
                int i = 1;
                Console.WriteLine("The goals are: ");
                foreach (Goal goal in Goals)
                {
                    Console.Write($"{i}. ");
                    goal.DisplayGoal();
                    i += 1;
                }
            }
            else if (choice == 3)
            {

            }
            else if (choice == 4)
            {

            }
            else if (choice == 5)
            {

            }
            else
            {
                Console.WriteLine("\nPlease enter a number between 1 and 6. \n");
            }
        }


    }
    static Goal CreateGoal(int option)
    {
        if (option == 1)
        {
            Goal simpleGoal1 = new SimpleGoal();
            return simpleGoal1;
            // Goals.Add(simpleGoal1);
            // Goal.AddGoal(simpleGoal1);
        }
        if (option == 2)
        {
            Goal eternalGoal1 = new EternalGoal();
            return eternalGoal1;
        }
        if (option == 3)
        {
            Goal checklistGoal1 = new ChecklistGoal();
            return checklistGoal1;
        }
        else
        {
            return null;
        }

        // }
        // else
        // {
        //     return eternalGoal1;
        // }

        //     Console.WriteLine("Invalid input.");
        //     Console.WriteLine("Press enter to continue. ");
        //     Console.ReadLine();
    }

}