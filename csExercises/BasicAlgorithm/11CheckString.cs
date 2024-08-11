using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(test("string"));
        Console.WriteLine(test("ab"));
        Console.WriteLine(test("cat"));
    }
    
    public static string test(string str)
    {
        if (str.Length > 2)
        {
            return str.Substring(0, 2) + str + str.Substring(0, 2);
        }
        else
        {
            return str; 
        }
    }
}
