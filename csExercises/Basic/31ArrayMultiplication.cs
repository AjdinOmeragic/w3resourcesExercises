using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr1 = {1, 3, -5, 4};
        int[] arr2 = {1, 4, -5, -2};
        int[] arr3 = new int[arr1.Length];
        
        for(int i = 0; i < arr1.Length; i++) 
        {
            arr3[i] = arr1[i] * arr2[i];
        }
        
        Console.WriteLine("The array:");
        foreach(var num in arr3)
        {
            Console.WriteLine(num);
        }
    }
}