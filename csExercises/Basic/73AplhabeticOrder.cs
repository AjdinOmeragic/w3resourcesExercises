using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] testStrings = { "PHP", "javascript", "python" };
        
        foreach (var str in testStrings)
        {
            Console.WriteLine($"Original string: {str}");
            string sortedString = toString(str);
            Console.WriteLine($"Converted: {sortedString}\n");
        }
    }

    static string toString(string input)
    {
        char[] chars = input.ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }
}
