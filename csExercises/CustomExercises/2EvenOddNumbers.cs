using System;

public class Program
{
    public static void Main(string[] args)
    {
        int num1 = 0, num2 = 0;
        
        for (int i = 0; i < 400; i += 2)
        {
            num1 += i;
        }
        
        for (int i = 0; i < 400; i += 3)
        {
            num2 += i;
        }
        
        Console.WriteLine("Num1: {0}\nNum2: {1}", num1, num2);
    }
}
