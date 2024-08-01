/*
4. Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.
Sample Input:
103
90
89
Expected Output:
True
True
False
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(inBound(103));
        Console.WriteLine(inBound(90));
        Console.WriteLine(inBound(80));
    }
    
    public static bool inBound(int num)
    {
        if ((num >= 90 && num <= 110) || (num >= 190 && num <= 210))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}