using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {5, 8, 3, 7, 1, 6, 9, 2, 4, 10, 
                     6, 7, 2, 5, 8, 3, 1, 4, 9, 10, 
                     2, 5, 8, 7, 3, 6, 1, 9, 4, 10, 
                     3, 6, 9, 2, 7, 5, 4, 8, 1, 10, 
                     4, 7, 2, 9, 1, 6, 8, 5, 3, 10, 
                     5, 1, 6, 8, 4, 3, 7, 9, 2, 10, 
                     8, 2, 5, 9, 1, 6, 4, 7, 3, 10, 
                     6, 4, 7, 3, 8, 2, 9, 5, 1, 10, 
                     7, 9, 1, 4, 5, 3, 8, 2, 6, 10, 
                     3, 8, 6, 1, 9, 4, 7, 2, 5, 10};

        int searchedNumber = 5;
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == searchedNumber)
            {
                count++;
            }
        }

        Console.WriteLine("Count of in array " + searchedNumber + ": " + count);
    }
}
