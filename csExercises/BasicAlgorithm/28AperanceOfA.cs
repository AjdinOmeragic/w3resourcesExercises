using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(test("caabb"));
        Console.WriteLine(test("bababa"));
        Console.WriteLine(test("aaaaa"));
    }
    
    public static bool test(string str)
    {
        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] == 'a' && str[i + 1] == 'a')
            {
                return true;
            }
        }
        return false;
    }
}
