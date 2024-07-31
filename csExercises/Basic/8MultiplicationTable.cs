/*
8. Write a C# Sharp program that prints the multiplication table of a number as input.
Test Data:
Enter the number: 5
Expected Output:
5 * 0 = 0
5 * 1 = 5
5 * 2 = 10
5 * 3 = 15
....
5 * 10 = 50
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num;
        
        Console.WriteLine("Enter the number: ");
        num = int.Parse(Console.ReadLine());
        
        for(int i = 1; i <= 10; i++){
            Console.WriteLine("{0} * {1} = {2}", num, i, num*i);
        }
    }
}