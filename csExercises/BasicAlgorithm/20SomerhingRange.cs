using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(test(78, 95));  
        Console.WriteLine(test(25, 35));  
        Console.WriteLine(test(40, 50));  
        Console.WriteLine(test(55, 60));  
    }

    public static bool test(int num1, int num2)
    {
        bool inFirstRange = (num1 >= 40 && num1 <= 50) && (num2 >= 40 && num2 <= 50);
        bool inSecondRange = (num1 >= 50 && num1 <= 60) && (num2 >= 50 && num2 <= 60);
        return inFirstRange || inSecondRange;
    }
}
