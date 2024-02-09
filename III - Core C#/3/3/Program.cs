using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number:");
        int decimalNumber = Convert.ToInt32(Console.ReadLine());

        string binary = Convert.ToString(decimalNumber, 2);

        Console.WriteLine($"Binary equivalent: {binary}");
    }
}
