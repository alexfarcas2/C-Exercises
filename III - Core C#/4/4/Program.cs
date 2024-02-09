using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double number2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the operation (+, -, *, /):");
        char operation = Convert.ToChar(Console.ReadLine());

        switch (operation)
        {
            case '+':
                Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
                break;
            case '-':
                Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
                break;
            case '*':
                Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
                break;
            case '/':
                if (number2 != 0)
                    Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
                else
                    Console.WriteLine("Cannot divide by zero.");
                break;
            default:
                Console.WriteLine("Unrecognized operation.");
                break;
        }
    }
}
