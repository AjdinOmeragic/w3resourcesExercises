/*
18. Write a C# program to check a pair of integers and return true if one is negative and one is positive.
Sample Output:
Input first integer:
-5
Input second integer:
25
Check if one is negative and one is positive:
True
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num1,num2;
        
        Console.WriteLine("Input first integer:");
        num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Input second integer:");
        num2 = int.Parse(Console.ReadLine());
     
        bool result = CheckIntegers(num1,num2);
        Console.WriteLine("One is negative and one is positive: {0}", result);
    }
    
    public static bool CheckIntegers(int a, int b){
        return (a < 0 && b > 0) || (a > 0 && b < 0);
    }
}