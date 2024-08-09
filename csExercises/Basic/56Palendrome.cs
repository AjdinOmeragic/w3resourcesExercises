using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(checkPalindrome("aaaaaaaaaa"));
        Console.WriteLine(checkPalindrome("Ajdin"));
        Console.WriteLine(checkPalindrome("OommoO"));
        Console.WriteLine(checkPalindrome("UwUwUwUwU"));
    }
    public static bool checkPalindrome(string inputString)
    {
        char[] c = inputString.ToCharArray();
        Array.Reverse(c);
        return new string(c).Equals(inputString);
    }
}
