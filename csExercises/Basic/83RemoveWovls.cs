using System;

class Program
{
    static void Main()
    {
        string[] testStrings = { "Python", "C Sharp", "JavaScript" };

        foreach (var str in testStrings)
        {
            string result = remover(str);
            Console.WriteLine($"Original string: {str}");
            Console.WriteLine($"After removing all the vowels from the said string: {result}");
            Console.WriteLine();
        }
    }

    static string remover(string input)
    {
        string vowels = "aeiouAEIOU";
        char[] result = Array.FindAll(input.ToCharArray(), c => !vowels.Contains(c));
        return new string(result);
    }
}
