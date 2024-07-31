/*
Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
Test Data:
Enter first number - 5
Enter second number - 6
Enter third number - 7
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num1,num2,num3;
        
        Console.WriteLine("Enter the first number: ");
        num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the second number: ");
        num2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the third number: ");
        num3 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Result of Specified numbers {0}, {1}, {2}: = \n(x+y).z is {3} \nx.y + y.z is {4}",num1,num2,num3,((num1+num2)*num3), ((num1*num2)+(num2*num3)));
    }
}
