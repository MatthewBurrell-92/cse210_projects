using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity1 = new Activity();
        activity1.GetInput();
    }

    // I created this ValidateInput function when I had a lot of code in
    // the program. I then decided to move it all to my Activity object.

    // static bool ValidateInput(string input)
    // {
    //     int number;
    //     if (int.TryParse(input, out number))
    //     {
    //         if (number >= 1 && number <= 5)
    //         {
    //             return true;
    //         }
    //         else
    //         {
    //             return false;
    //         }
    //     }
    //     else
    //     {
    //         return false;
    //     }
    // }
}