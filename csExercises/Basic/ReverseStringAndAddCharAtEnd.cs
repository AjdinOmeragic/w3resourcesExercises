using System;

class ReverseAndAddCharacter
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        string reversed = Reverse(input);
        char lastChar = input[input.Length - 1];
        string modifiedString = lastChar + reversed + lastChar;
        Console.WriteLine("Modified string: " + modifiedString);
    }
    static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
