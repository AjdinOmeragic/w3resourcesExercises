using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(countaa("bbaaccaag"));
        Console.WriteLine(countaa("jjkiaaasew"));
        Console.WriteLine(countaa("JSaaakoiaa"));
    }
    
    public static int countaa(string str)
    {
        int count = 0;
        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] == 'a' && str[i + 1] == 'a')
            {
                count++;
            }
        }
        return count;
    }
}
