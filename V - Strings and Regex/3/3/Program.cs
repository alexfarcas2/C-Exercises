using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        var result = DecimalDigitInformation(input);

        Console.WriteLine(result);
    }

    static string DecimalDigitInformation(string str)
    {
        Regex regex = new Regex(@"\d");
        Match match = regex.Match(str);

        if (match.Success)
        {
            return $"Digit {match.Value} at position {match.Index}";
        }
        else
        {
            return "No digit found!";
        }
    }
}
