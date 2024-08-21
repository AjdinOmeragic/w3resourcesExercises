using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter num2:");
        string strNum1 = Console.ReadLine();

        Console.WriteLine("Enter num1:");
        string strNum2 = Console.ReadLine();
        int num1 = int.Parse(strNum1);
        int num2 = int.Parse(strNum2);
        int minValue = Math.Min(num1, num2);
        Console.WriteLine("Min: " + minValue);
    }
}
