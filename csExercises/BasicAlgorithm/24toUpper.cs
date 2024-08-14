using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(toUpper("Python"));
        Console.WriteLine(toUpper("Javascript"));
        Console.WriteLine(toUpper("js"));
        Console.WriteLine(toUpper("PHP"));
    }
    
    public static string toUpper(string str)
    {
        if (str.Length < 3)
        {
            return str.ToUpper();
        }
        else
        {
            string firstPart = str.Substring(0, str.Length - 3);
            string lastPart = str.Substring(str.Length - 3).ToUpper();
            return firstPart + lastPart;
        }
    }
}
