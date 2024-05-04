using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        // List<int> numbersSorted = new List<int>();
        int addNumber = -1;
        int total = 0;
        double average = 0;
        int max = 0;
        int smallPositive = 100000;
        Console.WriteLine("Enter numbers to add them to a list. Entering 0 stops the program. ");
        do 
        {
            Console.Write("What number do you want to add? ");
            string userInput = Console.ReadLine();
            addNumber = int.Parse(userInput);
            if (addNumber != 0)
            {
                numbers.Add(addNumber);
            }
        } while (addNumber !=0);
        // Console.WriteLine(numbers);
        foreach (int number in numbers)
        {
            total += number;
            if (max <= number)
            {
                max = number;
            }
            if (number > 0 && number < smallPositive)
            {
                smallPositive = number;
                Console.WriteLine($"new small {number}");
            }
        }
        numbers.Sort();
        
        average = ((double)total / numbers.Count);
        Console.WriteLine($"The total of the list is {total}. ");
        Console.WriteLine($"The average of the list is {average}. ");
        Console.WriteLine($"The highest number of the list is {max}. ");
        Console.WriteLine($"The smallest positive integer is {smallPositive}. ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}