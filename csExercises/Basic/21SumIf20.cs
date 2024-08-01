/*
21. Write a C# program to check the sum of the two given integers. 
Return true if one of the integers is 20 or if their sum is 20.
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(SumTest(12,8));
        Console.WriteLine(SumTest(20,0));
        Console.WriteLine(SumTest(0,0));
    }
    
    public static bool SumTest(int num1, int num2){
        int sum = num1+num2;
        if(num1 == 20 || num2 == 20 || sum==20){
            return true;
        } else {
            return false; 
        }
    }
}