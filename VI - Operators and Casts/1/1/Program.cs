using System;

public class Rational
{
    public int Numerator { get; private set; }
    public int Denominator { get; private set; }

    public Rational(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }

        Numerator = numerator;
        Denominator = denominator;
    }

    // Method to display the rational number in the format "numerator/denominator"
    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }

    // Method to add two Rational numbers
    public static Rational operator +(Rational a, Rational b)
    {
        return new Rational(a.Numerator * b.Denominator + b.Numerator * a.Denominator,
                            a.Denominator * b.Denominator);
    }

    // Additional operators (subtraction, multiplication, division) and comparison operators
    // should be implemented similarly
}

class Program
{
    static void Main()
    {
        Rational r1 = new Rational(1, 2);
        Rational r2 = new Rational(3, 4);

        Rational sum = r1 + r2;
        Console.WriteLine($"Sum: {sum}");
    }
}
