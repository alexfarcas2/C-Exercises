using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input the number of elements to be stored in the array:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"element - {i}:");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0;
        foreach (int item in array)
        {
            sum += item;
        }

        Console.WriteLine($"Sum of all elements stored in the array is: {sum}");
    }
}
