using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] testStrings = { "Python", "JavaScript" };

        foreach (var str in testStrings)
        {
            List<int> indixes = lowerIndex(str);
            Console.WriteLine($"Original string: {str}");
            Console.WriteLine("indixes of all lower case letters of the said string:");
            Console.WriteLine(string.Join(" ", indixes));
            Console.WriteLine();
        }
    }

    static List<int> lowerIndex(string input)
    {
        List<int> indixes = new List<int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsLower(input[i]))
            {
                indixes.Add(i);
            }
        }

        return indixes;
    }
}
