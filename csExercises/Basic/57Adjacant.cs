using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(adjacent_Elements_Product(new int[] { 1, -3, 4, -5, 1 })); 
        Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 3, 4, 5, 2 })); 
    }
    
    public static int adjacent_Elements_Product(int[] arr)
    {
        int max = arr[0] * arr[1];
        for (int i = 1; i <= arr.Length - 2; i++)
        {
            max = Math.Max(max, arr[i] * arr[i + 1]);
        }
        return max;
    }
}
