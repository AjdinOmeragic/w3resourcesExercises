/*
28. Write a C# program to reverse the words of a sentence.
Sample Output:
Original String: Display the pattern like pyramid using the alphabet.
Reverse String: alphabet. the using pyramid like pattern the Display
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string str = "Display the pattern like pyramid using the alphabet.";
        Console.WriteLine("Reverse Output: {0}",str);
        Console.WriteLine("Reverse Output: {0}",reverseString(str));
    }
    public static string reverseString(string str){
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
