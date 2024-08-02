/*
6. Write a C# Sharp program to remove the character at a given position in the string. The given position will be in the range 0..(string length -1) inclusive.

Sample Input:
"Python", 1
"Python", o
"Python", 4
Expected Output:
Pthon
ython
Pythn
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string str = "Python";
        Console.WriteLine(RemoveCharacter(str, 1));
        Console.WriteLine(RemoveCharacter(str, 0));
        Console.WriteLine(RemoveCharacter(str, 4));
        
    }
    public static string RemoveCharacter(string str, int num)
    {
        if (num < 0 || num >= str.Length || str.Length == 0)
        {
            return "Invalid Input";
        }
        else
        {
            
            return str.Substring(0, num) + str.Substring(num + 1);
        }
    }
}
