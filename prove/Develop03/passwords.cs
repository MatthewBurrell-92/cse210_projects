using System;

public class Password
{
    private string _password;
    private string _userName;

    public Password(string userName, string password)
    {
        _userName = userName;
        _password = password;
    }
    public bool CheckPassword(string input)
    {
        if (input == _password)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}