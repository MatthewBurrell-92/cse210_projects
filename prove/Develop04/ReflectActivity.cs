using System;

public class ReflectionActivity : Activity
{
    private string _reflectPrompt;
    private string _question;

    public ReflectionActivity() : base()
    {
        _activityName = "Reflection";
        _description = "This activity will help you reflect on times in your life " +
        "when you have shown strength and resilience. This will help you recignize " +
        "the power you have and how you can use it in other aspects of your life. ";
    }

    public string GetRandomPrompt()
    {
        string prompt1 = "Think of a time when you stood up for someone else. ";
        string prompt2 = "Think of a time when you did something really difficult. ";
        string prompt3 = "Think of a time when you helped someone in need. ";
        string prompt4 = "Think of a time when you did something truly selfless. ";

        List<string> prompts = new List<string>();
        prompts = [prompt1,prompt2,prompt3,prompt4];

        Random number = new Random( );
        int index = number.Next(prompts.Count);
        _reflectPrompt = prompts[index];
        return _reflectPrompt;
    }
    public string GetRandomQuestion()
    {
        string question1 = "Why was this experience meaningful to you? ";
        string question2 = "Have you ever done anything like this before? ";
        string question3 = "How did you get started? ";
        string question4 = "How did you feel when it was complete? ";
        string question5 = "What made this time different than other times when you were not as successful? ";
        string question6 = "What is your favorite thing about this experience? ";
        string question7 = "What could you learn from this experience that applies to other situations? ";
        string question8 = "What did you learn about yourself through this experience? ";
        string question9 = "How can you keep this experience in mind in the future? ";

        List<string> questions = new List<string>();
        questions = [question1,question2,question3,question4,question5,
        question6,question7,question8,question9];

        Random number = new Random( );
        int index = number.Next(questions.Count);
        _question = questions[index];
        return _question;
    }
    public void CycleRandomQuestions(int duration)
    {
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            Console.Write(GetRandomQuestion());
            DisplayAnimation();
            DisplayAnimation();
            Console.Write("\n");
            currentTime = DateTime.Now;
        }        
    }
    public void RunReflectionActivity()
    {
        DisplayBeginningMessage();
        Console.WriteLine(" ");
        Duration();
        Console.Clear();
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine(" ");
        Console.WriteLine("When you think have something in mind, press enter. ");
        Console.WriteLine(" ");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplayAnimation();
        Console.Clear();
        CycleRandomQuestions(_duration);
        DisplayEndingMessage();
        Console.Clear();
    }
}