using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            double squareRoot = Math.Sqrt(i);
            Console.WriteLine($"Number: {i}, Square Root: {squareRoot}");
        }
    }
}

