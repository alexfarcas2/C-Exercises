public class Temperature
{
    public double Value { get; private set; }

    public Temperature(double value)
    {
        Value = value;
    }

    public void DisplayTemperature()
    {
        if (Value == 0)
        {
            throw new TempIsZeroException("Temperature is zero.");
        }
        Console.WriteLine($"Temperature: {Value} degrees.");
    }
}

public class TempIsZeroException : Exception
{
    public TempIsZeroException(string message) : base(message) { }
}
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        bool continueProgram = true;

        while (continueProgram)
        {
            try
            {
                Console.WriteLine("Enter the index of the element you want to see (0-4):");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"The element at index {index} is: {numbers[index]}");

                Console.WriteLine("Do you want to see another number? (yes/no)");
                continueProgram = Console.ReadLine().ToLower() == "yes";
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index was outside the bounds of the array. Please try again.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        // Demonstration of Temperature class
        try
        {
            Temperature temp = new Temperature(0); // Try different values
            temp.DisplayTemperature();
        }
        catch (TempIsZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
