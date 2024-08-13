using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(test(1, 2, 3));
        Console.WriteLine(test(1, 3, 2));
        Console.WriteLine(test(1, 1, 1));  
        Console.WriteLine(test(1, 2, 2)); 
    }

    public static int test(int num1, int num2, int num3)
    {
        int max = num1;
        
        if (max < num2)
        {
            max = num2;
        }
        
        if (max < num3)
        {
            max = num3;
        }
        
        return max;
    }
}
