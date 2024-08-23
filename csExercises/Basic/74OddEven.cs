using System;

class Program
{
    static void Main()
    {
        string[] testStrings = { "PHP", "javascript", "python" };
        
        foreach (var str in testStrings)
        {
            Console.WriteLine($"OG string: {str}");
            string result = checkString(str);
            Console.WriteLine($"Test: {result}\n");
        }
    }

    static string checkString(string input)
    {
        if (input.Length % 2 == 0)
        {
            return "Even";
        }
        else
        {
            return "Odd";
        }
    }
}
