/*
16. Write a C# program to create a new string from a given string where the first and last characters change their positions.
Test Data:
w3resource
Python
Sample Output:
e3resourcw
nythoP
x
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string a = "w3resources";
        string b = "Python";

        Console.WriteLine(SwapFirstAndLastCharacters(a));
        Console.WriteLine(SwapFirstAndLastCharacters(b));
    }

    public static string SwapFirstAndLastCharacters(string str)
    {
        if (str.Length <= 1)
        {
            return str; 
        }

        char firstChar = str[0];
        char lastChar = str[str.Length - 1];
        
        if (str.Length == 2)
        {
            return $"{lastChar}{firstChar}";
        }
        string middlePart = str.Substring(1, str.Length - 2); 
        return $"{lastChar}{middlePart}{firstChar}";
    }
}
