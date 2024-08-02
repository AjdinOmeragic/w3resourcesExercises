/*

*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string str = "Write a C# Sharp Program to display the following pattern using the alphabet.";
        
        string[] words = str.Split(new[] { " " }, StringSplitOptions.None);
        
        string longestWord = "";
        int count = 0;
        
        foreach (string s in words)
        {
            if (s.Length > count)
            {
                count = s.Length;
                longestWord = s;
            }
        }
        
        Console.WriteLine("The longest word is: " + longestWord);
    }
}
