using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int number;

        while (true)
        {
            Console.WriteLine("Enter a number (enter a number ending in 00 to stop):");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 100 == 0 && number != 0)
                break;

            numbers.Add(number);
        }

        Console.WriteLine("Entered numbers are:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}
