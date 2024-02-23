using System;

class Program
{
    static void Main()
    {
        // Declare an array of 5 integers
        int[] numbers = new int[5];

        // Ask the user to input a formula
        Console.WriteLine("Enter a formula to generate values for the array elements (e.g., n^2):");
        string formula = Console.ReadLine();

        // Fill the array with values based on the user-defined formula
        for (int i = 0; i < numbers.Length; i++)
        {
            int n = i + 1;
            numbers[i] = EvaluateFormula(formula, n);
        }

        // Print the array elements
        Console.WriteLine("Array elements:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Find the largest element in the array
        int largest = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }

        // Print the largest element
        Console.WriteLine("Largest element in the array: " + largest);
    }

    static int EvaluateFormula(string formula, int n)
    {
        // Split the formula string into parts
        string[] parts = formula.Split('^');

        // Parse the power value from the formula
        if (parts.Length != 2 || !int.TryParse(parts[1], out int power))
        {
            throw new ArgumentException("Invalid formula format. Expected format: n^power");
        }

        // Evaluate the formula based on the given power
        return (int)Math.Pow(n, power);
    }
}
