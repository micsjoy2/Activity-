using System;

class SimpleFunctionsDemo
{
    // Function to add two integers and return the result
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Function to print a message to the console
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
        int x = 10;
        int y = 3;

        int sum = Add(x, y);
        PrintMessage($"Sum of {x} and {y} is {sum}");

        int num = 6;
        int fact = Factorial(num);
        PrintMessage($"Factorial of {num} is {fact}");
    }
}

