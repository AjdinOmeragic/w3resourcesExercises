/*
27. Write a C# program and compute the sum of an integer's digits.
Sample Output:
Input a number(integer): 12
Sum of the digits of the said integer: 3
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string num = "12"; 
        int sum = 0;
        
        for (int i = 0; i < num.Length; i++)
        {
            int val = int.Parse(num[i].ToString());
            sum += val;
        }
        
        Console.WriteLine("The sum of the digit {0} is: {1}",num,sum);
    }
}
