using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr1 = {1, 2, 5};
        int[] arr2 = {0, 3, 8};
        int[] arr3 = {-1, 0, 2};
        int[] newArr = {arr1[1], arr2[1], arr3[1]};

        Console.WriteLine("Array: {0}", string.Join(", ", newArr));
    }
}
