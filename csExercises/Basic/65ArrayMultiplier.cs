using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int[] result = Multiplier(numbers);
        Console.WriteLine("array:");
        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }

    public static int[] Multiplier(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = arr[i] * arr.Length;
        }
        return arr;
    }
}
