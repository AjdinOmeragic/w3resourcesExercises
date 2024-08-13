using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(test(78, 95));
        Console.WriteLine(test(95, 95));
        Console.WriteLine(test(99, 70));
    }

    public static int test(int num1, int num2)
    {
        if (num1 == num2)
        {
            return 0;
        }
        
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }
}
