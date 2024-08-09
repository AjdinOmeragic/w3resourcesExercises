using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter 1: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter 2: ");
        int num2 = int.Parse(Console.ReadLine());

        if ((num1 % 2 == 0 && num2 % 2 == 0) || (num1 % 2 != 0 && num2 % 2 != 0))
        {
            Console.WriteLine("Both numbers are either even or odd.");
        }
        else
        {
            Console.WriteLine("The numbers have different parities.");
        }
    }
}
