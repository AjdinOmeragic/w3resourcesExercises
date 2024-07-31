/*
9. Write a C# Sharp program that takes four numbers as input to calculate and print the average.
Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the third number: 20
Enter the four number: 30

Expected Output:
The average of 10 , 15 , 20 , 30 is: 18
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num1,num2,num3,num4;
        
        Console.WriteLine("Enter the first number: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Second number: ");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Third number: ");
        num3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Fourth number: ");
        num4 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("( {0} + {1} + {2} + {3} ) / 4 = {4}", num1, num2, num3, num4, (num1 + num2 + num3 + num4) / 4);
    }
}
