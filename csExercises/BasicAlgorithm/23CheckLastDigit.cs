using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(test(123, 456));
        Console.WriteLine(test(12, 512));
        Console.WriteLine(test(7, 87));
        Console.WriteLine(test(12, 45));
    }
    
    public static bool test(int num1, int num2)
    {
        int lastDigit1 = num1 % 10;
        int lastDigit2 = num2 % 10;
        return lastDigit1 == lastDigit2;
    }
}