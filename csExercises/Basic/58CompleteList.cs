using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(consecutive(new int[] {1, 3, 5, 6, 9}));
        Console.WriteLine(consecutive(new int[] {1, 10}));
    }
    
    public static int consecutive(int[] arr)
    {
        Array.Sort(arr); 
        int ctr = 0;
        for(int i = 0; i < arr.Length - 1; i++)
        {
            ctr += arr[i+1] - arr[i] - 1;
        }
        return ctr;
    }
}
