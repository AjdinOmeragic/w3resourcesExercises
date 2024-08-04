using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num1, num2;
        Console.WriteLine("Enter first Number: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second Number: ");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine(numberCheck(num1, num2));
    }

    public static bool numberCheck(int num1, int num2)
    {
        bool isNum1InRange = num1 >= -10 && num1 <= 10;
        bool isNum2InRange = num2 >= -10 && num2 <= 10;
        
        return (isNum1InRange && !isNum2InRange) || (!isNum1InRange && isNum2InRange);
    }
}

/*
NOTE: There is an issue with this code however Im not sure why It keeps returning true?
*/