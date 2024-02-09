using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input the number of elements to be stored in the array:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        List<int> evenList = new List<int>();
        List<int> oddList = new List<int>();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"element - {i}:");
            array[i] = Convert.ToInt32(Console.ReadLine());

            if (array[i] % 2 == 0)
            {
                evenList.Add(array[i]);
            }
            else
            {
                oddList.Add(array[i]);
            }
        }

        Console.WriteLine("The Even elements are:");
        foreach (var even in evenList)
        {
            Console.Write(even + " ");
        }

        Console.WriteLine("\nThe Odd elements are:");
        foreach (var odd in oddList)
        {
            Console.Write(odd + " ");
        }
    }
}
