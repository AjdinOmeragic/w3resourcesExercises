using System;

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        string reversed = Reverse(input);
        Console.WriteLine("Reversed string: " + reversed);
    }
    static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        string result = string.Empty;
        for (int i = charArray.Length - 1; i >= 0; i--)
        {
            result += charArray[i];
        }

        return result;
    }
}
