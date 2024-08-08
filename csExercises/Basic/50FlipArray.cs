using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {2, 8, 1};  
        int temp = arr[0];
        for (int i = 0; i < arr.Length - 1; i++)
        {
            arr[i] = arr[i + 1];
        }
        arr[arr.Length - 1] = temp;
        
        Console.Write("FlipFloped: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
