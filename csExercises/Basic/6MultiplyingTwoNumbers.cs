/*
Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
Test Data:
Input the first number to multiply: 2
Input the second number to multiply: 3
Input the third number to multiply: 6

Expected Output:
2 x 3 x 6 = 36
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int numb1, numb2, numb3, multiplication;
        
        Console.WriteLine("Enter the First Number: ");
        numb1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the Second Number: ");
        numb2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the Third Number: ");
        numb3 = int.Parse(Console.ReadLine());
        
        multiplication = numb1 * numb2 * numb3;
        Console.WriteLine(numb1 + " x " + numb2 + " x " + numb3 + " = " + multiplication);
    }
}
