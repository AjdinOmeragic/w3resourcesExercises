using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(test("frizz"));
        Console.WriteLine(test("zane"));
        Console.WriteLine(test("Zazz"));
        Console.WriteLine(test("false"));
        Console.WriteLine(test("zzzz"));
        Console.WriteLine(test("ZZZZ"));
    }
    
    public static bool test(string str)
    {
        int count = 0;
        str = str.ToLower();
        foreach (char c in str)
        {
            if (c == 'z')
            {
                count++;
            }
        }
        return count >= 2 && count <= 4;
    }
}
