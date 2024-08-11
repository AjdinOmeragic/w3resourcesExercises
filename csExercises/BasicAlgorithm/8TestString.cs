using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(test("C Sharp"));
        Console.WriteLine(test("bd"));
        Console.WriteLine(test("db")); 
    }
    
    public static string test(string str)
    {
        return str.Length < 2
            ? str 
            : str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2);
    }
}
