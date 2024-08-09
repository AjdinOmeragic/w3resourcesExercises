using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] str = new string[3];
        
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter Value:");
            str[i] = Console.ReadLine();
        }
        
        Console.WriteLine("Before: {0}", string.Join(", ", str));
        
        Array.Reverse(str);
        
        Console.WriteLine("After: {0}", string.Join(", ", str));
    }
}
