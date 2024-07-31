/*
Write a C# Sharp program to swap two numbers.

Test Data:
Input the First Number : 5
Input the Second Number : 6

Expected Output after Swapping:
First Number : 6
Second Number : 5
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int numb1, numb2, temp;
        Console.WriteLine("Input the First Number: ");
        numb1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Input the Second Number: ");
        numb2 = int.Parse(Console.ReadLine());
        
        temp = numb1;
        numb1 = numb2;
        numb2 = temp;
        
        Console.WriteLine("Output after Swapping: ");
        Console.WriteLine("First Number: " + numb1);
        Console.WriteLine("Second Number: " + numb2);
        
        
    }
}