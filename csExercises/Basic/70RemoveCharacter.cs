using System;

class Program
{
    static void Main()
    {
        string[] testStrings = { "PHP", "Python", "JavaScript" };

        foreach (var str in testStrings)
        {
            Console.WriteLine($"OG string: {str}");
            if (str.Length > 2)
            {
                string result = str.Substring(1, str.Length - 2);
                Console.WriteLine($"After operation: {result}");
            }
            else
            {
                Console.WriteLine("To short man");
            }

            Console.WriteLine();
        }
    }
}
