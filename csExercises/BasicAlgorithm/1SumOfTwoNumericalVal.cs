/*
1. Write a C# Sharp program to compute the sum of the two numerical values. If the two values are the same, return triple their sum.
Sample Input:
1, 2
3, 2
2, 2
Expected Output:
3
5
12   
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(numTest(1,3));
        Console.WriteLine(numTest(3,2));
        Console.WriteLine(numTest(2,2));
        Console.WriteLine(numTest(6,6));
    }
    
    public static int numTest(int num1, int num2){
        if(num1==num2){
            return 3*(num1 + num2);
        } else {
            return num1+num2;
        }
    }
}