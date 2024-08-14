using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(writeFirstThree("Python", 2));
        Console.WriteLine(writeFirstThree("Python", 3));
        Console.WriteLine(writeFirstThree("JS", 3));
        Console.WriteLine(writeFirstThree("Sam", 2));
    }
    
    public static string writeFirstThree(string str, int num)
    {
        string newStr = "";
        string firstThreeStr;
        if (str.Length < 3)
        {
            firstThreeStr = str;
        }
        else
        {
            firstThreeStr = str.Substring(0, 3);
        }
        for (int i = 0; i < num; i++)
        {
            newStr += firstThreeStr;
        }
        return newStr;
    }
}
