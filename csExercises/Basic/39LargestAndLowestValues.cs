using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num1 = 3,num2 = 15,num3 = 50;
        int max = Math.Max(num1, Math.Max(num2, num3));
        int min = Math.Min(num1, Math.Min(num2, num3));
        Console.WriteLine("Max: {0} \nMin: {1}", max, min);
    }
}
