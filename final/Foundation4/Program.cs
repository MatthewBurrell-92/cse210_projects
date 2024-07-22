using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running running1 = new Running("5 NOV 1605", 25, 3.0F);
        activities.Add(running1);
        Cycling cycling1 = new Cycling("11 July 2024", 60, 6.0F);
        activities.Add(cycling1);
        Swimming swimming1 = new Swimming("12 AUG 2023", 30, 50.0F);
        activities.Add(swimming1);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}