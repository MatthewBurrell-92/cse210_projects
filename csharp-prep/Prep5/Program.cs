using System;

class Program
{
    // static void Main(string[] args)
    static void Main()
    {
        // Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string name = PromptUserName();
        double number = PromptUserNumber();
        double square = SquareNumber(number);
        DisplayResult(name, square);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static double PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string user_input = Console.ReadLine();
        double number = double.Parse(user_input);
        return number;
    }
    static double SquareNumber(double number)
    {
        double square = (number * number);
        return square;
    }
    static void DisplayResult(string name, double square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
    // Main();
}