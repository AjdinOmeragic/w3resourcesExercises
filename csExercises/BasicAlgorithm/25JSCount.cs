using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(writeJS("JS", 2));
        Console.WriteLine(writeJS("JS", 3));
        Console.WriteLine(writeJS("JS", 1));
        Console.WriteLine(writeJS("JS", 6));
    }
    
    public static string writeJS(string str, int num)
    {
        string result = "";
        for (int i = 0; i < num; i++)
        {
            result += str;
        }

        return result;
    }
}
