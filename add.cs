using System;

class Program
{
    static void Main()
    {
        // Input variables
        int num1, num2;

        // Getting input from user
        Console.WriteLine("Enter the first number:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        num2 = Convert.ToInt32(Console.ReadLine());

        // Adding two numbers
        int sum = num1 + num2;

        // Displaying the result
        Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
    }
}
