using System;

public class Entry
{
    public string _entryPrompt;
    public string _entryInput;
    public string _entryDate;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_entryDate} - {_entryPrompt} ");
        Console.WriteLine(_entryInput);
    }
    public string WriteFileHelp()
    {
        // This function made writing the file easier on me....
        // There is probably a more efficient way to go about it,
        // but she works, so I'm not touching her.
        string file_line = (_entryDate + "*" + _entryPrompt + "*" + _entryInput);
        return file_line;
    }
}