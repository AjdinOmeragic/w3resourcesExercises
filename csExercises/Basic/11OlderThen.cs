/*
11. Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You look older than 20".
Test Data:
Enter your age - 25
Expected Output:
You look older than 25
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your age: ");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Your look Older then 25");
    }
}