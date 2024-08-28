using System;
class Program
{
    static void Main()
    {
        string[] testStr = { "abcd", "abc", "a" };

        foreach (var str in testStr)
        {
            string result = aabacadabara(str);
            Console.WriteLine(result);
        }
    }

    static string aabacadabara(string input)
    {
        string result = "";

        for (int i = 1; i <= input.Length; i++)
        {
            result += input.Substring(0, i);
        }

        return result;
    }
}
