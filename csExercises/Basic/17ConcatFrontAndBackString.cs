/*
17. Write a C# program to create a string from a given string (length 1 or more) with the first character added at the front and back.
Sample Output:
Input a string : The quick brown fox jumps over the lazy dog.
TThe quick brown fox jumps over the lazy dog.T
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       string str = "pep";
       char c = str[0];
      
        Console.WriteLine("{0}{1}{2}", c,str,c);
    }
}