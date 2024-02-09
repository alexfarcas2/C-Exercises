using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer:");
        int number = Convert.ToInt32(Console.ReadLine());

        bool containsThree = IfNumberContains3(number);

        Console.WriteLine($"Does the number contain digit 3? {containsThree}");
    }

    static bool IfNumberContains3(int number)
    {
        while (number > 0)
        {
            if (number % 10 == 3)
                return true;

            number /= 10;
        }

        return false;
    }
}
