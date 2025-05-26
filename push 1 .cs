using System;

class SimpleFunctionsDemo
{
    // Function to add two integers and return the result
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Function to print a message
    static void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    // Function to calculate factorial of a number recursively
    static int Factorial(int n)
    {
        if (n <= 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    static void Main()
    {
        int x = 9;
        int y = 8;

        // Call Add function and print the result
        int sum = Add(x, y);
        PrintMessage($"Sum of {x} and {y} is {sum}");

        // Call Factorial function and print the result
        int num = 4;
        int fact = Factorial(num);
        PrintMessage($"Factorial of {num} is {fact}");
    }
}

