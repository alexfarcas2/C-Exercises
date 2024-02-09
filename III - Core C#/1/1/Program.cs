using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string inputString = Console.ReadLine();

        int alphabetCount = 0, digitCount = 0, specialCharCount = 0;

        foreach (char c in inputString)
        {
            if (char.IsLetter(c))
                alphabetCount++;
            else if (char.IsDigit(c))
                digitCount++;
            else
                specialCharCount++;
        }

        Console.WriteLine($"Number of Alphabets in the string is: {alphabetCount}");
        Console.WriteLine($"Number of Digits in the string is: {digitCount}");
        Console.WriteLine($"Number of Special characters in the string is: {specialCharCount}");
    }
}
