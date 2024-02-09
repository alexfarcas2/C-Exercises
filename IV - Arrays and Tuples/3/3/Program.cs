using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input the size of the square matrix (less than 5):");
        int size = Convert.ToInt32(Console.ReadLine());
        int[,] firstMatrix = new int[size, size];
        int[,] secondMatrix = new int[size, size];
        int[,] sumMatrix = new int[size, size];

        Console.WriteLine("Input elements in the first matrix:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                firstMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Input elements in the second matrix:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                secondMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                sumMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
            }
        }

        Console.WriteLine("The Addition of two matrices is:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(sumMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
