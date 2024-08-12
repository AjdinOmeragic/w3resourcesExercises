using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(test(20, 84, 30));
        Console.WriteLine(test(14, 50, 60));
        Console.WriteLine(test(11, 45, 25));
        Console.WriteLine(test(25, 40, 10)); 
    }

    public static bool test(int num1, int num2, int num3)
    {
        if((num1 > 19 && num1 < 51) || (num2 > 19 && num2 < 51) || (num3 > 19 && num3 < 51))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
