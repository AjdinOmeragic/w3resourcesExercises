using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(test(20, 84));
        Console.WriteLine(test(14, 50));
        Console.WriteLine(test(11, 45));
        Console.WriteLine(test(25, 40)); 
    }

    public static bool test(int num1, int num2)
    {
        if((num1 > 19 && num1 < 51) || (num2 > 19 && num2 < 51))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
