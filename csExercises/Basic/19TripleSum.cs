/*
19. Write a C# program to compute the sum of two given integers. 
If two values are the same, return the triple of their sum.
*/


using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int a = 10, b = 10, sum;
        
        if(a==b){
            sum = 3*(a+b);
        } else {
            sum = a + b;
        }
        
        Console.WriteLine("Sum is: {0}", sum);
        
    }
}