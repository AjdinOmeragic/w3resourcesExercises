using System;

class SimpleCalculator
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int sum = num1 + num2;
        Console.WriteLine("Sum: " + sum);
        int difference = num1 - num2;
        Console.WriteLine("Difference: " + difference);
        int product = num1 * num2;
        Console.WriteLine("Product: " + product);
        if (num2 != 0)
        {
            double quotient = (double)num1 / num2;
            Console.WriteLine("Quotient: " + quotient);
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed.");
        }
    }
}
