using System;

class Program
{
    static void Main()
    {
        // Initialize an array of integers
        int[] numbers = new int[] { 1, 2, 3, 4, 5 };

        // Print the array elements
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return a / b;
    }
}