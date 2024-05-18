using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("I'm going to rip my hair out. ");
        string userInput = Console.ReadLine();
        int age;
        if (int.TryParse(userInput, out age))
        {
            // use the age variable
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer value for your age.");
        }
    }
}