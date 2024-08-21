using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to encode:");
        string input = Console.ReadLine();
        string codedString = EncodeString(input);
        Console.WriteLine("Coded string:");
        Console.WriteLine(codedString);
    }

    public static string EncodeString(string str)
    {
        str = str.Replace('P', '9');
        str = str.Replace('T', '0');
        str = str.Replace('S', '1');
        str = str.Replace('H', '6');
        str = str.Replace('A', '8');
        return str;
    }
}
