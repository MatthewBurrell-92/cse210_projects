using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Matthew", "Programing");
        Console.WriteLine(assignment1.GetSummary());
        MathAssignment assignment2 = new MathAssignment("Matthew", "Algebra", "7.6", "1-20");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        WritingAssignment assignment3 = new WritingAssignment("Matthew", "How Bad was Hitler", "Hitler was Really Bad");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }

    
}