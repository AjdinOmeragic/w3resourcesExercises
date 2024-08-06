using System;

public class Program
{
    public static void Main(string[] args)
    {
        int count = 100; 
        int sum = 0;

        for (int i = 1; i <= count; i++)
        {
            int num1 = (2 * i) - 1; 
            int num2 = 2 * i;       
            num2 = num2 * num2;     

            sum += num1 + num2;

            
            Console.WriteLine($"Iteration {i}: {num1} + {num2} = {sum}");
        }

        Console.WriteLine($"Final sum is {sum}");
    }
}
