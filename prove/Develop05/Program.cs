using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> Goals = new List<Goal>();
        Gamification game1 = new Gamification();
        bool quit = false;
        while (quit == false)
        {
            Console.WriteLine("");
            Console.WriteLine($"You have {game1.DisplayPoints()} points");
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
                    Goal simpleGoal1 = new SimpleGoal();
                    Goals.Add(simpleGoal1);
                }
                else if (choice2 == 2)
                {
                    Goal eternalGoal1 = new EternalGoal();
                    Goals.Add(eternalGoal1);
                }
                else if (choice2 == 3)
                {
                    Goal checklistGoal1 = new ChecklistGoal();
                    Goals.Add(checklistGoal1);
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
                Console.WriteLine("To what file would you like to save your goals? ");
                string file_name = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(file_name))
                {
                    game1.SaveToFile(outputFile);
                    outputFile.WriteLine("");
                    foreach (Goal goal in Goals)
                    {
                        goal.SaveToFile(outputFile);
                        outputFile.WriteLine("");
                    }
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("");
                Console.WriteLine("What file do you want to load? ");
                string filename = Console.ReadLine();
                try
                {
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    game1.AddPoints(int.Parse(lines[0]));

                    lines = lines.Skip(1).ToArray();

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split("/");
                        int goalType = int.Parse(parts[0]);
                        if (goalType == 1)
                        {
                            Goal simpleGoal1 = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]),
                            bool.Parse(parts[4]));
                            Goals.Add(simpleGoal1);
                        }
                        if (goalType == 2)
                        {
                            Goal eternalGoal1 = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]),
                            int.Parse(parts[4]));
                            Goals.Add(eternalGoal1);
                        }
                        if (goalType == 3)
                        {
                            Goal checklistGoal1 = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                            int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                            Goals.Add(checklistGoal1);
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("File is in incorrect format, empty, or doesn't exist. ");
                }
            }

            else if (choice == 5)
            {
                Console.WriteLine("Goals are: ");
                int i = 1;
                foreach (Goal goal in Goals)
                {
                    Console.Write($"{i}. ");
                    goal.DisplayGoalName();
                    i += 1;
                }
                Console.WriteLine("Which goal did you accomplish? ");
                string input3 = Console.ReadLine();
                int choice3 = -1;
                int totalGoals = Goals.Count + 1;
                try
                {
                    choice3 = int.Parse(input3);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                if (choice3 <= Goals.Count & choice3 > 0)
                {
                    Goals[choice3 - 1].RecordEvent(game1);
                }
            }
            else if (choice == 6)
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("\nPlease enter a number between 1 and 6. \n");
            }
        }
    }
}