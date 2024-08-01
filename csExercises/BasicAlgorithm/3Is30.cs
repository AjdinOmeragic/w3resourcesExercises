/*
3. Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.

Sample Input:
30, 0
25, 5
20, 30
20, 25
Expected Output:
True
True
True
False
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(ifThirty(30,0));
        Console.WriteLine(ifThirty(25, 5));
        Console.WriteLine(ifThirty(20, 30));
        Console.WriteLine(ifThirty(20, 25));
    }
    
    public static bool ifThirty(int num1, int num2){
        if(num1 == 30 || num2 == 30){
            return true;
        } else if((num1+num2)==30){
            return true;
        } else {
            return false;
        }
    }
}