using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        bool result = AlmostOnlyLetters(input);

        Console.WriteLine($"Is the string valid? {result}");
    }

    static bool AlmostOnlyLetters(string str)
    {
        return Regex.IsMatch(str, @"^[A-Za-z\s]+\.$");
    }
}
