using System;

class Program
{
    static void Main(string[] args)
    {
        int command = 0;
        Journal journal1 = new Journal();
        while (command != 5)
        {
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Quit ");

            command = PromptInput();
            if (command == 1)
            {
                string prompt = PromptGenerator();
                Entry entryNew = journal1.AddEntry(prompt);
                journal1._entries.Add(entryNew);
            }
            if (command == 2)
            {
                journal1.DisplayJournal();
            }
            if (command == 3)
            {
                Console.Write("What file would you like to load? ");
                string file_name = Console.ReadLine();
                List<Entry> entries = journal1.LoadFromFile(file_name);
                foreach (Entry entry in entries)
                {
                    journal1._entries.Add(entry);
                }
            }
            if (command == 4)
            {
                Console.Write("What file would you like to save the journal to? ");
                string file_name = Console.ReadLine();
                journal1.SaveToFile(file_name);
            }
        }
    }

    static int PromptInput()
    {
        // This function prompts the user for what they would like to do.
        bool valid = false;
        string input = "";
        while (valid == false)
        {
        Console.Write("What would you like to do? ");
        input = Console.ReadLine();
        valid = ValidateInput(input);
        if (!valid)
        {
            Console.WriteLine("Invalid response. Try again. ");
        }
        }
        int command = int.Parse(input);
        return command;
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
    static string PromptGenerator()
    {
        // This function stores all my prompts and returns a random one when called.
        string prompt_1 = "What was the best part of my day? ";
        string prompt_2 = "Who was the most interesting person I interacted with today? ";
        string promtp_3 = "How did I see the hand of the Lord in my life today? ";
        string prompt_4 = "What was the strongest emotion I felt today? ";
        string prompt_5 = "If I had one thing I could do over today, what would it be? ";
        string prompt_6 = "What is something you never want to forget about today? ";
        List<string> prompts = new List<string>();
        prompts = [prompt_1,prompt_2,promtp_3,prompt_4,prompt_5,
        prompt_6,];

        Random rnd = new();
        int which_prompt = rnd.Next(0,5);
        string prompt = prompts[which_prompt];
        return prompt;
    }
}