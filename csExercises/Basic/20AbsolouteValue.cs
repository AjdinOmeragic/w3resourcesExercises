/*
20. Write a C# program to get the absolute value of the difference between two given numbers. 
Return double the absolute value of the difference if the first number is greater than the second number.
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num1 = 160, num2 = 40, val;
        val = num1-num2;
        
        if (val<0){
            val=val*(-1);
        } else {
            val = val;
        }
        
        Console.WriteLine("Absoulte Value is: {0}", val);
    }
}