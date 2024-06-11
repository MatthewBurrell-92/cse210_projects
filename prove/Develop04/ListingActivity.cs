using System;

public class ListingActivity : Activity
{
    private string _listingPrompt;

    public ListingActivity() : base()
    {
        _listingPrompt = "Muh butt";
    }

    public string GetRandomPrompt()
    {
        return "PROMPT";
    }
    public void GetAnswers()
    {
        Console.WriteLine("");
        Console.WriteLine("Hello Develop04 World!");

    }
}