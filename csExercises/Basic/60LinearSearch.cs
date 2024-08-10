using System;

public class SimpleSearch
{
    public static int LinearSearch(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i;
            }
        }
        return -1; 
    }

    public static void Main()
    {
        int[] numbers = { 3, 8, 12, 5, 6, 14 };
        int target = 5;
        int result = LinearSearch(numbers, target);
        if (result != -1)
        {
            Console.WriteLine($"Index: {result}");
        }
        else
        {
            Console.WriteLine("Not in array sorry");
        }
    }
}
