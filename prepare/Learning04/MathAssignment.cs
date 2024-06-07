using System;

public class MathAssignment : Assignment
{
    private string _textbookSections;
    private string _problems;

    public MathAssignment(string student, string topic, string textbookSections, string problems) : base(student, topic)
    {
        _textbookSections = textbookSections;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Student: {_student} Topic: {_topic}{Environment.NewLine}"
        + $"Section {_textbookSections} Problems {_problems}";
    }
}