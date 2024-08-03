using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string str, hello = "Hello";
        bool result;
        Console.WriteLine("Enter the string: ");
        str = Console.ReadLine();
        result = str.Contains(hello);
        Console.WriteLine(result);
    }
}