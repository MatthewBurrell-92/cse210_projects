using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage for the class? ");
        string userInput = Console.ReadLine();
        // I found this trick, the Substring method, on StackOverflow.
        int secondDigit = int.Parse(userInput.Substring(1,1));
        int percentage = int.Parse(userInput);
        string letter = " ";
        string stretch = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (percentage >= 70)
        {
            Console.WriteLine("You passed! Congratulations! ");
        }
        if (percentage < 94 && percentage > 69)
        {
            if (secondDigit >= 7)
            {
                stretch = "+";
            }
            else if (secondDigit <= 3)
            {
                stretch = "-";
            }
            else{
                stretch = "";
            }
        }

        Console.WriteLine($"Your letter grade was {letter}{stretch}. ");
    }
}