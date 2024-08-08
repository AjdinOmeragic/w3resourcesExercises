using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};  
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        
        Console.WriteLine("Sum: {0}", sum);
    }
}
