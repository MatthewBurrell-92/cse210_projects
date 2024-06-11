using System;

public class ReflectActivity : Activity
{
    private string _reflectPrompt;
    private string _question;

    public ReflectActivity() : base()
    {
        _reflectPrompt = "Muh life";
    }

    public string GetRandomPrompt()
    {
        return "butts";
    }
    public string GetRandomQuestion()
    {
        return "QUESTion";
    }
}