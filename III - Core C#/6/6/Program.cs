using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the base number:");
        int baseNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the exponent:");
        int exponent = Convert.ToInt32(Console.ReadLine());

        long result = ToThePowerOf(baseNumber, exponent);

        Console.WriteLine($"Result: {baseNumber} raised to the power of {exponent} is {result}");
    }

    static long ToThePowerOf(int baseNum, int exp)
    {
        long result = 1;
        for (int i = 1; i <= exp; i++)
        {
            result *= baseNum;
        }
        return result;
    }
}
