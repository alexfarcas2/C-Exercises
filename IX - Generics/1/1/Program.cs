public static class Utils
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}
class Program
{
    static void Main()
    {
        // Example with integers
        int a = 2, b = 3;
        Console.WriteLine($"Before swap: a={a}; b={b}");
        Utils.Swap(ref a, ref b);
        Console.WriteLine($"After swap: a={a}; b={b}");

        // Example with strings
        string str1 = "abc", str2 = "def";
        Console.WriteLine($"\nBefore swap: a={str1}; b={str2}");
        Utils.Swap(ref str1, ref str2);
        Console.WriteLine($"After swap: a={str1}; b={str2}");
    }
}
