using System;

public class Assignment
{
    protected string _student;
    protected string _topic;
    public Assignment(string student, string topic)
    {
        _student = student;
        _topic = topic;
    }
    public string GetSummary()
    {
        return $"Student: {_student} Topic: {_topic}";
    }
}