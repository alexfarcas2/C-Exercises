using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first string:");
        string firstString = Console.ReadLine();

        Console.WriteLine("Enter the second string:");
        string secondString = Console.ReadLine();

        string mixedString = MixTwoStrings(firstString, secondString);

        Console.WriteLine($"Mixed String: {mixedString}");
    }

    static string MixTwoStrings(string str1, string str2)
    {
        var mixed = new System.Text.StringBuilder();

        for (int i = 0; i < Math.Max(str1.Length, str2.Length); i++)
        {
            if (i < str1.Length)
            {
                mixed.Append(str1[i]);
            }
            if (i < str2.Length)
            {
                mixed.Append(str2[i]);
            }
        }

        return mixed.ToString();
    }
}
