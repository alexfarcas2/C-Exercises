using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Before interchange: Number1 = " + number1 + ", Number2 = " + number2);

        // Swapping the values
        int temp = number1;
        number1 = number2;
        number2 = temp;

        Console.WriteLine("After interchange: Number1 = " + number1 + ", Number2 = " + number2);
    }
}
