using System;

public class ListingActivity : Activity
{
    private string _listingPrompt;

    public ListingActivity() : base()
    {
        _activityName = "Listing";
        _description = "This activity will help you reflect on the good things in your " +
        "life by having you list as many things as you can in a certain time. ";
    }

    public string GetRandomPrompt()
    {
        string prompt1 = "Who are people that you appreciate? ";
        string prompt2 = "What are personal strengths of yours? ";
        string prompt3 = "Who are people that you have helped this week? ";
        string prompt4 = "When have you felt the Holy Ghost this month? ";
        string prompt5 = "Who are some of your personal heroes? ";

        List<string> prompts = new List<string>();
        prompts = [prompt1,prompt2,prompt3,prompt4,prompt5];

        Random number = new Random( );
        int index = number.Next(prompts.Count);
        _listingPrompt = prompts[index];
        return _listingPrompt;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"---{_listingPrompt}---");
    }
    public void GetAnswers(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            currentTime = DateTime.Now;
        }
    }
    public void RunListingActivity()
    {
        // As previously stated in the BreathingActivity, I'm not using
        // this method anymore. 
        DisplayBeginningMessage();
        Console.WriteLine(" ");
        Duration();
        Console.Clear();
        // Console.WriteLine("Get ready...");
        // DisplayAnimation();
        // _listingPrompt = GetRandomPrompt();
        // Console.WriteLine($"---{_listingPrompt}---");
        // Console.WriteLine(" ");
        // Console.WriteLine($"You may begin in 5 seconds...");
        // DisplayAnimation();
        // Console.Clear();
        // Console.WriteLine($"---{_listingPrompt}---");
        // // GetAnswers(_duration);
        // DisplayEndingMessage();
        // Console.Clear();
    }
}