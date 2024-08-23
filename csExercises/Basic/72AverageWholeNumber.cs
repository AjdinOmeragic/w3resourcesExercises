using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] nums = { 1, 2, 3, 5, 4, 2, 3, 4 };
        int[] nums1 = { 2, 4, 2, 6, 4, 8 };
        int[] emptyArray = { };

        CheckAndPrint(nums);
        CheckAndPrint(nums1);
        CheckAndPrint(emptyArray);
    }

    static void CheckAndPrint(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            Console.WriteLine("The array is empty or null.");
            return;
        }

        Console.WriteLine("Array = { " + string.Join(", ", arr) + " }");
        Console.WriteLine("Is avg whole number?" + IsWholeNumberAverage(arr));
        Console.WriteLine();
    }

    static bool IsWholeNumberAverage(int[] arr)
    {
        double average = arr.Average();
        return average % 1 == 0;
    }
}
